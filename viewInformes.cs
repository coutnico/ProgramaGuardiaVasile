using CapturarIngresos.Models;
using SpreadsheetLight;
using SpreadsheetLight.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapturarIngresos
{
    public partial class viewInformes : Form
    {

        DatabaseLoader loader = new DatabaseLoader();

        public viewInformes()
        {
            InitializeComponent();
        }

        private void CargarFechaenLabel(DateTime fecha)
        {
            string dia = fecha.Day.ToString();
            string mes = fecha.Month.ToString();
            string año = fecha.Year.ToString();
            string cadena = "";

            if (dia.Length == 1 && mes.Length == 1)
            {
                cadena = "0" + dia + "/0" + mes + "/" + año;
            }
            else if (dia.Length == 2 && mes.Length == 1)
            {
                cadena = dia + "/0" + mes + "/" + año;
            }
            else if (dia.Length == 1 && mes.Length == 2)
            {
                cadena = "0" + dia + "/" + mes + "/" + año;
            }
            else if (dia.Length == 2 && mes.Length == 2)
            {
                cadena = dia + "/" + mes + "/" + año;
            }

            lblFecha.Text = cadena;
        }

        private void Calendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime fechafiltrada = Calendario.SelectionRange.Start;
            CargarFechaenLabel(fechafiltrada);
            Calendario.Visible = false;
        }

        private void ibAceptar_Click(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "Informe.xlsx";
            System.Drawing.Image image = Properties.Resources.LOGO_VASILE_CON_NOMBRE;
            string rutaimagen = Path.Combine(Path.GetTempPath(), "imagen_temporal.png");
            image.Save(rutaimagen, System.Drawing.Imaging.ImageFormat.Png);

            SLDocument document = new SLDocument();
            SLPicture imagen = new SLPicture(rutaimagen);
            imagen.SetPosition(0.5, 1.2);
            imagen.ResizeInPercentage(30, 30);
            document.InsertPicture(imagen);

            // Definir estilos para los títulos
            SLStyle styleTitulo1 = new SLStyle();
            styleTitulo1.Font.Bold = true;
            styleTitulo1.Font.FontSize = 32;
            styleTitulo1.Alignment.Horizontal = DocumentFormat.OpenXml.Spreadsheet.HorizontalAlignmentValues.Center;
            styleTitulo1.Alignment.Vertical = DocumentFormat.OpenXml.Spreadsheet.VerticalAlignmentValues.Center;
            SLStyle styleTitulo = new SLStyle();
            styleTitulo.Font.Bold = true;
            styleTitulo.Font.FontSize = 16;
            styleTitulo.Alignment.Horizontal = DocumentFormat.OpenXml.Spreadsheet.HorizontalAlignmentValues.Center;
            styleTitulo.Alignment.Vertical = DocumentFormat.OpenXml.Spreadsheet.VerticalAlignmentValues.Center;

            SLStyle styleContenido = new SLStyle();
            styleContenido.Alignment.Horizontal = DocumentFormat.OpenXml.Spreadsheet.HorizontalAlignmentValues.Center;
            styleContenido.Alignment.Vertical = DocumentFormat.OpenXml.Spreadsheet.VerticalAlignmentValues.Center;

            document.SetCellValue(5, 5, "REGISTRO ASISTENCIA");
            document.SetCellStyle(5, 5, styleTitulo1);
            document.SetCellValue(9, 2, "Legajo");
            document.SetCellStyle(9, 2, styleTitulo);
            document.SetCellValue(9, 3, "Apellido");
            document.SetCellStyle(9, 3, styleTitulo);
            document.SetCellValue(9, 4, "Nombre");
            document.SetCellStyle(9, 4, styleTitulo);
            document.SetCellValue(9, 5, "Fecha");
            document.SetCellStyle(9, 5, styleTitulo);
            document.SetCellValue(9, 6, "Hora Ingreso");
            document.SetCellStyle(9, 6, styleTitulo);


            SLStyle styleBorde = new SLStyle();
            styleBorde.Border.LeftBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
            styleBorde.Border.LeftBorder.Color = System.Drawing.Color.Black;
            styleBorde.Border.RightBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
            styleBorde.Border.RightBorder.Color = System.Drawing.Color.Black;
            styleBorde.Border.TopBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
            styleBorde.Border.TopBorder.Color = System.Drawing.Color.Black;
            styleBorde.Border.BottomBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
            styleBorde.Border.BottomBorder.Color = System.Drawing.Color.Black;

            DataTable personal = loader.LoadData("Empleados");
            DataTable ConTarjeta = loader.LoadData("IngresosEmpleados");
            DataTable SinTarjeta = loader.LoadData("IngresosSinTarjeta");

            DataTable resultado = new DataTable();
            ConTarjeta.Merge(SinTarjeta);

            TimeSpan horaPruduccion = new TimeSpan(7, 0, 0);
            TimeSpan horaFalta = new TimeSpan(7, 45, 0);

            //CargoColumnas
            resultado.Columns.Add("Legajo", typeof(string));
            resultado.Columns.Add("Apellido", typeof(string));
            resultado.Columns.Add("Nombre", typeof(string));
            resultado.Columns.Add("Fecha", typeof(string));
            resultado.Columns.Add("HoraIngre", typeof(string));

            int fila = 10;


            if (cbFiltro.SelectedItem == "EN HORARIO")
            {
                resultado.Rows.Clear();
                bool band = false;

                foreach (DataRow linearegistro in ConTarjeta.Rows)
                {
                    HorarioEmpleado empleado = BuscarHorarioMasProximo(Convert.ToInt32(linearegistro[0]));

                    TimeSpan horaregistro = TimeSpan.Parse(linearegistro[7].ToString());
                    TimeSpan horaprestablecida = TimeSpan.Parse(empleado.HoraIngreso);
                    string fecharegistro = linearegistro[6].ToString();

                    if (fecharegistro == lblFecha.Text)
                    {
                        if (horaregistro <= horaprestablecida)
                        {
                            document.SetCellValue(fila, 2, linearegistro[0].ToString());
                            document.SetCellStyle(fila, 2, styleContenido);
                            document.SetCellValue(fila, 3, linearegistro[1].ToString());
                            document.SetCellStyle(fila, 3, styleContenido);
                            document.SetCellValue(fila, 4, linearegistro[2].ToString());
                            document.SetCellStyle(fila, 4, styleContenido);
                            document.SetCellValue(fila, 5, linearegistro[6].ToString());
                            document.SetCellStyle(fila, 5, styleContenido);
                            document.SetCellValue(fila, 6, linearegistro[7].ToString());
                            document.SetCellStyle(fila, 6, styleContenido);

                            fila++; // Mover a la siguiente fila
                            band = true;
                        }
                    }
                }

                if (band)
                {

                    int totalfilas = document.GetWorksheetStatistics().EndRowIndex;

                    int totalColumnas = document.GetWorksheetStatistics().EndColumnIndex;

                    // Establecer el ancho para cada columna
                    for (int columna = 1; columna <= totalColumnas; columna++)
                    {
                        document.SetColumnWidth(columna, 20);
                    }

                    for (int row = 10; row <= totalfilas; row++)
                    {
                        for (int columna = 2; columna <= totalColumnas; columna++)
                        {
                            document.SetCellStyle(row, columna, styleBorde);
                        }
                    }

                    document.ImportDataTable(1, 1, resultado, false);
                    document.SaveAs(path);
                    MessageBox.Show("Informe creado con éxito");

                    // Abrir el archivo con la aplicación predeterminada
                    Process.Start(path);
                }
                else
                {
                    MessageBox.Show("No se encontraron filas correspondientes a los filtros");
                }
            }
            else if (cbFiltro.SelectedItem == "LLEGADAS TARDE")
            {
                resultado.Rows.Clear();
                bool band = false;

                foreach (DataRow linearegistro in ConTarjeta.Rows)
                {
                    HorarioEmpleado empleado = BuscarHorarioMasProximo(Convert.ToInt32(linearegistro[0]));

                    TimeSpan horaregistro = TimeSpan.Parse(linearegistro[7].ToString());
                    TimeSpan horaprestablecida = TimeSpan.Parse(empleado.HoraIngreso);
                    string fecharegistro = linearegistro[6].ToString();

                    if (fecharegistro == lblFecha.Text)
                    {
                        if (horaprestablecida == horaPruduccion)
                        {
                            if (horaregistro > horaprestablecida && horaregistro <= horaFalta)
                            {
                                document.SetCellValue(fila, 2, linearegistro[0].ToString());
                                document.SetCellStyle(fila, 2, styleContenido);
                                document.SetCellValue(fila, 3, linearegistro[1].ToString());
                                document.SetCellStyle(fila, 3, styleContenido);
                                document.SetCellValue(fila, 4, linearegistro[2].ToString());
                                document.SetCellStyle(fila, 4, styleContenido);
                                document.SetCellValue(fila, 5, linearegistro[6].ToString());
                                document.SetCellStyle(fila, 5, styleContenido);
                                document.SetCellValue(fila, 6, linearegistro[7].ToString());
                                document.SetCellStyle(fila, 6, styleContenido);

                                fila++; // Mover a la siguiente fila
                                band = true;
                            }

                        }
                        else
                        {
                            if (horaregistro > horaprestablecida)
                            {
                                document.SetCellValue(fila, 2, linearegistro[0].ToString());
                                document.SetCellStyle(fila, 2, styleContenido);
                                document.SetCellValue(fila, 3, linearegistro[1].ToString());
                                document.SetCellStyle(fila, 3, styleContenido);
                                document.SetCellValue(fila, 4, linearegistro[2].ToString());
                                document.SetCellStyle(fila, 4, styleContenido);
                                document.SetCellValue(fila, 5, linearegistro[6].ToString());
                                document.SetCellStyle(fila, 5, styleContenido);
                                document.SetCellValue(fila, 6, linearegistro[7].ToString());
                                document.SetCellStyle(fila, 6, styleContenido);

                                fila++; // Mover a la siguiente fila
                                band = true;
                            }
                        }

                    }

                }

                if (band)
                {
                    int totalfilas = document.GetWorksheetStatistics().EndRowIndex;

                    int totalColumnas = document.GetWorksheetStatistics().EndColumnIndex;

                    // Establecer el ancho para cada columna
                    for (int columna = 1; columna <= totalColumnas; columna++)
                    {
                        document.SetColumnWidth(columna, 20);
                    }

                    for (int row = 10; row <= totalfilas; row++)
                    {
                        for (int columna = 2; columna <= totalColumnas; columna++)
                        {
                            document.SetCellStyle(row, columna, styleBorde);
                        }
                    }

                    document.ImportDataTable(1, 1, resultado, false);
                    document.SaveAs(path);
                    MessageBox.Show("Informe creado con exito");

                    Process.Start(path);
                }
                else
                {
                    MessageBox.Show("No se encontraron filas correspondientes a los filtros");
                }
            }
            else if (cbFiltro.SelectedItem == "FALTA")
            {
                resultado.Rows.Clear();
                bool band = false;

                foreach (DataRow linearegistro in ConTarjeta.Rows)
                {
                    HorarioEmpleado empleado = BuscarHorarioMasProximo(Convert.ToInt32(linearegistro[0]));

                    TimeSpan horaregistro = TimeSpan.Parse(linearegistro[7].ToString());
                    TimeSpan horaprestablecida = TimeSpan.Parse(empleado.HoraIngreso);

                    string fecharegistro = linearegistro[6].ToString();

                    if (fecharegistro == lblFecha.Text)
                    {
                        if (horaregistro == horaPruduccion)
                        {
                            if (horaregistro > horaFalta)
                            {
                                document.SetCellValue(fila, 2, linearegistro[0].ToString());
                                document.SetCellStyle(fila, 2, styleContenido);
                                document.SetCellValue(fila, 3, linearegistro[1].ToString());
                                document.SetCellStyle(fila, 3, styleContenido);
                                document.SetCellValue(fila, 4, linearegistro[2].ToString());
                                document.SetCellStyle(fila, 4, styleContenido);
                                document.SetCellValue(fila, 5, linearegistro[6].ToString());
                                document.SetCellStyle(fila, 5, styleContenido);
                                document.SetCellValue(fila, 6, linearegistro[7].ToString());
                                document.SetCellStyle(fila, 6, styleContenido);

                                fila++; // Mover a la siguiente fila
                                band = true;
                            }
                        }
                    }
                }

                if (band)
                {
                    int totalfilas = document.GetWorksheetStatistics().EndRowIndex;

                    int totalColumnas = document.GetWorksheetStatistics().EndColumnIndex;

                    // Establecer el ancho para cada columna
                    for (int columna = 1; columna <= totalColumnas; columna++)
                    {
                        document.SetColumnWidth(columna, 20);
                    }

                    for (int row = 10; row <= totalfilas; row++)
                    {
                        for (int columna = 2; columna <= totalColumnas; columna++)
                        {
                            document.SetCellStyle(row, columna, styleBorde);
                        }
                    }


                    document.ImportDataTable(1, 1, resultado, false);
                    document.SaveAs(path);
                    MessageBox.Show("Informe creado con exito");

                    Process.Start(path);
                }
                else
                {
                    MessageBox.Show("No se encontraron filas correspondientes a los filtros");
                }
            }
            else
            {
                DataTable Faltas = new DataTable();
                DataTable Llegadastarde = new DataTable();
                DataTable EnHorario = new DataTable();



                Faltas.Columns.Add("Legajo", typeof(string));
                Faltas.Columns.Add("Apellido", typeof(string));
                Faltas.Columns.Add("Nombre", typeof(string));
                Faltas.Columns.Add("DNI", typeof(string));
                Faltas.Columns.Add("NroTarjeta", typeof(string));
                Faltas.Columns.Add("Sector", typeof(string));
                Faltas.Columns.Add("Fecha", typeof(string));
                Faltas.Columns.Add("HoraIngre", typeof(string));
                Faltas.Columns.Add("HoraSali", typeof(string));
                Faltas.Columns.Add("Motivo", typeof(string));
                Faltas.Columns.Add("Explayo", typeof(string));

                Llegadastarde.Columns.Add("Legajo", typeof(string));
                Llegadastarde.Columns.Add("Apellido", typeof(string));
                Llegadastarde.Columns.Add("Nombre", typeof(string));
                Llegadastarde.Columns.Add("DNI", typeof(string));
                Llegadastarde.Columns.Add("NroTarjeta", typeof(string));
                Llegadastarde.Columns.Add("Sector", typeof(string));
                Llegadastarde.Columns.Add("Fecha", typeof(string));
                Llegadastarde.Columns.Add("HoraIngre", typeof(string));
                Llegadastarde.Columns.Add("HoraSali", typeof(string));
                Llegadastarde.Columns.Add("Motivo", typeof(string));
                Llegadastarde.Columns.Add("Explayo", typeof(string));

                EnHorario.Columns.Add("Legajo", typeof(string));
                EnHorario.Columns.Add("Apellido", typeof(string));
                EnHorario.Columns.Add("Nombre", typeof(string));
                EnHorario.Columns.Add("DNI", typeof(string));
                EnHorario.Columns.Add("NroTarjeta", typeof(string));
                EnHorario.Columns.Add("Sector", typeof(string));
                EnHorario.Columns.Add("Fecha", typeof(string));
                EnHorario.Columns.Add("HoraIngre", typeof(string));
                EnHorario.Columns.Add("HoraSali", typeof(string));
                EnHorario.Columns.Add("Motivo", typeof(string));
                EnHorario.Columns.Add("Explayo", typeof(string));

                //estilos celdas
                SLStyle styleFaltas = new SLStyle();
                SLStyle styleTarde = new SLStyle();
                SLStyle styleEnHorario = new SLStyle();

                //aplicarfiltros
                styleFaltas.Alignment.Horizontal = DocumentFormat.OpenXml.Spreadsheet.HorizontalAlignmentValues.Center;
                styleFaltas.Alignment.Vertical = DocumentFormat.OpenXml.Spreadsheet.VerticalAlignmentValues.Center;
                styleFaltas.Fill.SetPatternBackgroundColor(Color.Red);


                styleTarde.Alignment.Horizontal = DocumentFormat.OpenXml.Spreadsheet.HorizontalAlignmentValues.Center;
                styleTarde.Alignment.Vertical = DocumentFormat.OpenXml.Spreadsheet.VerticalAlignmentValues.Center;
                styleFaltas.Fill.SetPatternBackgroundColor(Color.Yellow);


                styleEnHorario.Alignment.Horizontal = DocumentFormat.OpenXml.Spreadsheet.HorizontalAlignmentValues.Center;
                styleEnHorario.Alignment.Vertical = DocumentFormat.OpenXml.Spreadsheet.VerticalAlignmentValues.Center;



                resultado.Rows.Clear();
                bool band = false;

                ConTarjeta.Merge(SinTarjeta);

                foreach (DataRow linearegistro in ConTarjeta.Rows)
                {
                    HorarioEmpleado empleado = BuscarHorarioMasProximo(Convert.ToInt32(linearegistro[0]));

                    TimeSpan horaregistro = TimeSpan.Parse(linearegistro[7].ToString());
                    TimeSpan horaprestablecida = TimeSpan.Parse(empleado.HoraIngreso);

                    string fecharegistro = linearegistro[6].ToString();

                    if (fecharegistro == lblFecha.Text)
                    {
                        DataRow nuevaFila;

                        // Crear una nueva fila para cada DataTable y asignar los valores
                        if (horaregistro <= horaprestablecida)
                        {
                            nuevaFila = EnHorario.NewRow();
                            nuevaFila.ItemArray = linearegistro.ItemArray;
                            EnHorario.Rows.Add(nuevaFila);
                        }
                        if (horaprestablecida == horaPruduccion && horaregistro > horaprestablecida && horaregistro <= horaFalta)
                        {
                            nuevaFila = Llegadastarde.NewRow();
                            nuevaFila.ItemArray = linearegistro.ItemArray;
                            Llegadastarde.Rows.Add(nuevaFila);
                        }
                        if (horaprestablecida != horaPruduccion && horaregistro > horaprestablecida)
                        {
                            nuevaFila = Llegadastarde.NewRow();
                            nuevaFila.ItemArray = linearegistro.ItemArray;
                            Llegadastarde.Rows.Add(nuevaFila);
                        }
                        if (horaregistro == horaPruduccion && horaregistro > horaFalta)
                        {
                            nuevaFila = Faltas.NewRow();
                            nuevaFila.ItemArray = linearegistro.ItemArray;
                            Faltas.Rows.Add(nuevaFila);
                        }
                    }
                }


                foreach (DataRow falta in Faltas.Rows)
                {
                    document.SetCellValue(fila, 2, falta[0].ToString());
                    document.SetCellStyle(fila, 2, styleFaltas);
                    document.SetCellValue(fila, 3, falta[1].ToString());
                    document.SetCellStyle(fila, 3, styleFaltas);
                    document.SetCellValue(fila, 4, falta[2].ToString());
                    document.SetCellStyle(fila, 4, styleFaltas);
                    document.SetCellValue(fila, 5, falta[6].ToString());
                    document.SetCellStyle(fila, 5, styleFaltas);
                    document.SetCellValue(fila, 6, falta[7].ToString());
                    document.SetCellStyle(fila, 6, styleFaltas);

                    fila++; // Mover a la siguiente fila
                    band = true;
                }
                foreach (DataRow tarde in Llegadastarde.Rows)
                {
                    document.SetCellValue(fila, 2, tarde[0].ToString());
                    document.SetCellStyle(fila, 2, styleTarde);
                    document.SetCellValue(fila, 3, tarde[1].ToString());
                    document.SetCellStyle(fila, 3, styleTarde);
                    document.SetCellValue(fila, 4, tarde[2].ToString());
                    document.SetCellStyle(fila, 4, styleTarde);
                    document.SetCellValue(fila, 5, tarde[6].ToString());
                    document.SetCellStyle(fila, 5, styleTarde);
                    document.SetCellValue(fila, 6, tarde[7].ToString());
                    document.SetCellStyle(fila, 6, styleTarde);

                    fila++; // Mover a la siguiente fila
                    band = true;
                }
                foreach (DataRow enhorario in EnHorario.Rows)
                {
                    document.SetCellValue(fila, 2, enhorario[0].ToString());
                    document.SetCellStyle(fila, 2, styleEnHorario);
                    document.SetCellValue(fila, 3, enhorario[1].ToString());
                    document.SetCellStyle(fila, 3, styleEnHorario);
                    document.SetCellValue(fila, 4, enhorario[2].ToString());
                    document.SetCellStyle(fila, 4, styleEnHorario);
                    document.SetCellValue(fila, 5, enhorario[6].ToString());
                    document.SetCellStyle(fila, 5, styleEnHorario);
                    document.SetCellValue(fila, 6, enhorario[7].ToString());
                    document.SetCellStyle(fila, 6, styleEnHorario);

                    fila++; // Mover a la siguiente fila
                    band = true;
                }


                if (band)
                    {
                        int totalfilas = document.GetWorksheetStatistics().EndRowIndex;

                        int totalColumnas = document.GetWorksheetStatistics().EndColumnIndex;

                        // Establecer el ancho para cada columna
                        for (int columna = 1; columna <= totalColumnas; columna++)
                        {
                            document.SetColumnWidth(columna, 20);
                        }

                        for (int row = 10; row <= totalfilas; row++)
                        {
                            for (int columna = 2; columna <= totalColumnas; columna++)
                            {
                                document.SetCellStyle(row, columna, styleBorde);
                            }
                        }


                        document.ImportDataTable(1, 1, resultado, false);
                        document.SaveAs(path);
                        MessageBox.Show("Informe creado con exito");

                        Process.Start(path);
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron filas correspondientes a los filtros");
                    }
                }

            }

            private void ibCalendario_Click(object sender, EventArgs e)
            {
                if (!Calendario.Visible)
                {
                    Calendario.Visible = true;
                }
                else
                {
                    Calendario.Visible = false;
                }
            }

            private void viewInformes_Load(object sender, EventArgs e)
            {
                cbFiltro.Items.Add("TODOS");
                cbFiltro.Items.Add("EN HORARIO");
                cbFiltro.Items.Add("LLEGADAS TARDE");
                cbFiltro.Items.Add("FALTA");


                lblFecha.Text = ABM.getFechaActual();
            }

            private HorarioEmpleado BuscarHorarioMasProximo(int legajo)
            {

                //Obtener los diferentes cambios horarios que tuvo un empleado
                List<HorarioEmpleado> horarioEmpleados = new List<HorarioEmpleado>();
                HorarioEmpleado empleado = new HorarioEmpleado();

                DataTable cambioshorarios = loader.LoadData("Horarios");

                foreach (DataRow row in cambioshorarios.Rows)
                {
                    if (legajo == Convert.ToInt32(row[0]))
                    {
                        empleado.legajo = Convert.ToInt32(row[0]);
                        empleado.SetStringtoDate(row[1].ToString());
                        empleado.HoraIngreso = row[3].ToString();
                        empleado.HoraSalida = row[4].ToString();

                        horarioEmpleados.Add(empleado);
                    }
                }

                //Obtener el horario actualizado

                DateTime fechaActual = DateTime.Today;

                // Inicializar una variable para almacenar la diferencia mínima
                TimeSpan diferenciaMinima = TimeSpan.MaxValue;

                // Inicializar una variable para almacenar el horario más cercano
                HorarioEmpleado horarioMasCercano = null;

                // Iterar sobre cada elemento en la lista
                foreach (var horarioEmpleado in horarioEmpleados)
                {
                    // Calcular la diferencia entre la fecha actual y la fecha en el objeto HorarioEmpleado
                    TimeSpan diferencia = (horarioEmpleado.FechaModificacion - fechaActual).Duration();

                    // Si la diferencia actual es menor que la diferencia mínima, actualizar la diferencia mínima y el horario más cercano
                    if (diferencia < diferenciaMinima)
                    {
                        diferenciaMinima = diferencia;
                        horarioMasCercano = horarioEmpleado;
                    }
                }

                return horarioMasCercano;
            }

        }
    }
