using CapturarIngresos.Models;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CapturarIngresos
{
    public partial class RegistrosGuardados : Form
    {
        Ingresante nuevoingreso = new Ingresante();
        DatabaseLoader loader = new DatabaseLoader();
        string tabla = null;

        DataTable resultadosFiltrados;
        private PaginaPrincipal paginaPrincipal;
        DateTime fechafiltrada;


        DataTable TablaOriginal = new DataTable();

        public RegistrosGuardados(string modo)
        {

            InitializeComponent();
            this.tabla = modo;

        }
        public RegistrosGuardados(string modo, PaginaPrincipal page)
        {

            InitializeComponent();
            this.tabla = modo;

            paginaPrincipal = page;

            paginaPrincipal.DatosActualizados += PaginaPrincipal_DatosActualizados1;

        }

        private void PaginaPrincipal_DatosActualizados1(object sender, EventArgs e)
        {
            dgvIngresos.DataSource = null;

            DataTable dataTable = loader.LoadData("IngresosEmpleados");
            
            DataTable reversedDataTable = dataTable.Clone();

            // Invertir el orden de las filas del DataTable
            for (int i = dataTable.Rows.Count - 1; i >= 0; i--)
            {
                DataRow row = dataTable.Rows[i];
                reversedDataTable.ImportRow(row);
            }

            dgvIngresos.DataSource = reversedDataTable;
            dgvIngresos.Refresh();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            if (tabla == "IngresosEmpleados")
            {
                clConTarjeta.Visible = true;
                clSinTarjeta.Visible = true;
                clTodos.Visible = true;

                clConTarjeta.Checked = true;

                cbExternos.Visible = false;
                cbInternos.Visible = false;

            }

            if (tabla == "TransportesEntrada" || tabla == "TransportesSalida")
            {
                cbExternos.Visible = true;
                cbInternos.Visible = true;
            }


            if (tabla == "Choferes")
            {
                dataTable = loader.FiltrarDadosdeBaja(dataTable);

                dataTable = loader.FiltrarChoferes(dataTable);

            }
            else
            {

                dataTable = loader.LoadData(tabla);
            }

            DataTable reversedDataTable = dataTable.Clone();

            // Invertir el orden de las filas del DataTable
            for (int i = dataTable.Rows.Count - 1; i >= 0; i--)
            {
                DataRow row = dataTable.Rows[i];
                reversedDataTable.ImportRow(row);
            }

            dgvIngresos.DataSource = reversedDataTable;

            //Copia de Tabla principal 
            TablaOriginal = (dgvIngresos.DataSource as DataTable)?.Copy();

        }


        private void PaginaPrincipal_DatosActualizados(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void tboxBuscador_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tboxBuscador.Text))
            {
                // Si el TextBox está vacío, mostrar la tabla original
                dgvIngresos.DataSource = TablaOriginal?.Copy();
            }
            else
            {
                string filtro = tboxBuscador.Text.Trim().ToLower();
                List<DataRow> filasfiltradas = new List<DataRow>();


                foreach (DataRow row in TablaOriginal.Rows)
                {
                    foreach (DataColumn col in TablaOriginal.Columns)
                    {

                        if (col.ColumnName != "Fecha")
                        {
                            if (row[col].ToString().ToLower().Contains(filtro))
                            {
                                filasfiltradas.Add(row);
                                break;
                            }
                        }
                    }
                }
                resultadosFiltrados = TablaOriginal.Clone();

                foreach (DataRow fila in filasfiltradas)
                {
                    resultadosFiltrados.ImportRow(fila);
                }

                dgvIngresos.DataSource = resultadosFiltrados;

            }
        }

        private void dgvIngresos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvIngresos.Rows.Count && tabla == "IngresosEmpleados")
            {
                Empleado empleado = new Empleado();

                if (clConTarjeta.Checked)
                {


                    empleado.Legajo = Convert.ToInt32(dgvIngresos.Rows[e.RowIndex].Cells["Legajo"].Value.ToString());
                    empleado.Apellido = dgvIngresos.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();
                    empleado.Nombre = dgvIngresos.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                    empleado.NumeroDeTarjeta = Convert.ToInt32(dgvIngresos.Rows[e.RowIndex].Cells["NroTarjeta"].Value.ToString());
                    empleado.DNI = dgvIngresos.Rows[e.RowIndex].Cells["DNI"].Value.ToString();
                    empleado.Sector = dgvIngresos.Rows[e.RowIndex].Cells["Sector"].Value.ToString();
                    string fecha = dgvIngresos.Rows[e.RowIndex].Cells["Fecha"].Value.ToString();
                    string hora = dgvIngresos.Rows[e.RowIndex].Cells["HoraIngre"].Value.ToString();

                    IngresarSalida salida = new IngresarSalida(true, empleado.Legajo, empleado.Apellido, empleado.Nombre, empleado.NumeroDeTarjeta, empleado.DNI, empleado.Sector, fecha, hora);
                    salida.ShowDialog();
                }
                else
                {

                    empleado.Legajo = Convert.ToInt32(dgvIngresos.Rows[e.RowIndex].Cells["Legajo"].Value.ToString());
                    empleado.Apellido = dgvIngresos.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();
                    empleado.Nombre = dgvIngresos.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                    empleado.NumeroDeTarjeta = Convert.ToInt32(dgvIngresos.Rows[e.RowIndex].Cells["NroTarjeta"].Value.ToString());
                    empleado.DNI = dgvIngresos.Rows[e.RowIndex].Cells["DNI"].Value.ToString();
                    empleado.Sector = dgvIngresos.Rows[e.RowIndex].Cells["Sector"].Value.ToString();
                    string fecha = dgvIngresos.Rows[e.RowIndex].Cells["Fecha"].Value.ToString();
                    string hora = dgvIngresos.Rows[e.RowIndex].Cells["HoraIngre"].Value.ToString();
                    string motivo = dgvIngresos.Rows[e.RowIndex].Cells["Motivo"].Value.ToString();
                    string explayo = dgvIngresos.Rows[e.RowIndex].Cells["Explayo"].Value.ToString();

                    IngresarSalida salida = new IngresarSalida(false, empleado.Legajo, empleado.Apellido, empleado.Nombre, empleado.NumeroDeTarjeta, empleado.DNI, empleado.Sector, fecha, hora, motivo, explayo);
                    salida.ShowDialog();
                }


            }
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
            DataTable tablafiltrada;
            DataTable CopiaResultadosFiltrados = resultadosFiltrados;

            if (resultadosFiltrados == null)
            {
                tablafiltrada = TablaOriginal?.Copy();
            }
            else
            {
                CopiaResultadosFiltrados = resultadosFiltrados.Clone();
                foreach (DataRow row in resultadosFiltrados.Rows)
                {
                    CopiaResultadosFiltrados.ImportRow(row);
                }

                tablafiltrada = CopiaResultadosFiltrados;
            }



            dgvIngresos.DataSource = null;

            DataRow[] copiaFilas = tablafiltrada.Select();

            foreach (DataRow row in copiaFilas)
            {
                DateTime fecharegistro = DateTime.Parse(row["Fecha"].ToString());

                if (fechafiltrada != fecharegistro)
                {
                    tablafiltrada.Rows.Remove(row);
                }
            }

            dgvIngresos.DataSource = tablafiltrada;
            Calendario.Visible = false;

        }

        private void ibCalendario_Click(object sender, EventArgs e)
        {
            if (Calendario.Visible)
            {
                Calendario.Visible = false;
            }
            else
            {
                Calendario.Visible = true;
            }
        }

        private void clSinTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (clSinTarjeta.Checked)
            {
                dgvIngresos.DataSource = null;
                dgvIngresos.DataSource = loader.LoadData("IngresosSinTarjeta");

                TablaOriginal.Clear();
                TablaOriginal = (dgvIngresos.DataSource as DataTable)?.Copy();

            }
            else
            {
                dgvIngresos.DataSource = null;
            }
        }

        private void clTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (clTodos.Checked)
            {
                clConTarjeta.Checked = true;
                clSinTarjeta.Checked = true;

                dgvIngresos.DataSource = null;
                DataTable tabla1 = loader.LoadData("IngresosEmpleados");
                DataTable tabla2 = loader.LoadData("IngresosSinTarjeta");
                tabla1.Merge(tabla2);
                dgvIngresos.DataSource = tabla1;

                TablaOriginal.Clear();
                TablaOriginal = (dgvIngresos.DataSource as DataTable)?.Copy();

            }
            else
            {
                clConTarjeta.Checked = false;
                clSinTarjeta.Checked = false;
                dgvIngresos.DataSource = null;
            }
        }

        private void clConTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (clConTarjeta.Checked)
            {
                dgvIngresos.DataSource = null;
                dgvIngresos.DataSource = loader.LoadData("IngresosEmpleados");

                TablaOriginal.Clear();
                TablaOriginal = (dgvIngresos.DataSource as DataTable)?.Copy();
            }
            else
            {
                dgvIngresos.DataSource = null;
            }
        }

        private void cbExternos_CheckedChanged(object sender, EventArgs e)
        {
            if (tabla == "TransportesEntrada")
            {
                if (cbExternos.Checked)
                {
                    cbInternos.Checked = false;

                    dgvIngresos.DataSource= null;

                    dgvIngresos.DataSource = loader.LoadData("TransportesExternosEntrada");

                    TablaOriginal.Clear();
                    TablaOriginal = (dgvIngresos.DataSource as DataTable)?.Copy();
                }
                else
                {
                    dgvIngresos.DataSource = null;
                }
            }
            else if (tabla == "TransportesSalida")
            {
                if (cbExternos.Checked)
                {
                    cbInternos.Checked = false;

                    dgvIngresos.DataSource = null;

                    dgvIngresos.DataSource = loader.LoadData("TransportesExternosSalida");

                    TablaOriginal.Clear();
                    TablaOriginal = (dgvIngresos.DataSource as DataTable)?.Copy();
                }
                else
                {
                    dgvIngresos.DataSource = null;
                }
            }
        }

        private void cbInternos_CheckedChanged(object sender, EventArgs e)
        {
            if (tabla == "TransportesEntrada")
            {
                if (cbInternos.Checked)
                {
                    cbExternos.Checked = false;

                    dgvIngresos.DataSource = null;

                    dgvIngresos.DataSource = loader.LoadData("TransportesInternosEntrada");

                    TablaOriginal.Clear();
                    TablaOriginal = (dgvIngresos.DataSource as DataTable)?.Copy();
                }
                else
                {
                    dgvIngresos.DataSource = null;
                }
            }
            else if (tabla == "TransportesSalida")
            {
                if (cbInternos.Checked)
                {
                    cbExternos.Checked = false;

                    dgvIngresos.DataSource = null;

                    dgvIngresos.DataSource = loader.LoadData("TransportesInternosSalida");

                    TablaOriginal.Clear();
                    TablaOriginal = (dgvIngresos.DataSource as DataTable)?.Copy();
                }
                else
                {
                    dgvIngresos.DataSource = null;
                }
            }
        }
    }
}

