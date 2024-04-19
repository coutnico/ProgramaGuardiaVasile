using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CapturarIngresos.Models;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing.Imaging;
using System.IO;
using DotNetDBF;
using System.Text.RegularExpressions;
using System.Net;

namespace CapturarIngresos
{
    public partial class FormularioIngreso : Form
    {

        string fechaActual = DateTime.Today.ToString("dd/MM/yyyy");
        string horaactual = DateTime.Now.ToString("HH:mm");
        string UrlImage;
        string rutacarpetaVisitantes = "R:\\sistemas_nico\\CapturarIngresosVMate\\ImagenesCapturadas\\Visitantes\\";
        string rutaBase = "R:\\sistemas_nico\\CapturarIngresosVMate\\database\\";


        private DBFWriter writer;

        private FilterInfoCollection MisDispositivos;
        private VideoCaptureDevice MiCamara;
        string originalFilePathEmpleado = "R:\\sistemas_nico\\CapturarIngresosVMate\\database\\IngresosEmpleados.dbf";
        string originalFilePathVisitante = "R:\\sistemas_nico\\CapturarIngresosVMate\\database\\IngresosVisitante.dbf";

        public FormularioIngreso()
        {
            InitializeComponent();
        }


        //Inicializacion de WeCam
        private void CargarDispositivos()
        {
            MisDispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (MisDispositivos.Count > 0)
            {

                for (int i = 0; i < MisDispositivos.Count; i++)
                {
                    if (MisDispositivos[i].Name.ToString() == "GENERAL WEBCAM")
                        MiCamara = new VideoCaptureDevice(MisDispositivos[i].MonikerString);
                }


                VideoCapabilities[] resoluciones = MiCamara.VideoCapabilities;

                int indiceResolucion = 5;
                if (indiceResolucion >= 0 && indiceResolucion < resoluciones.Length)
                {
                    MiCamara.VideoResolution = resoluciones[indiceResolucion];

                    MiCamara.NewFrame += new NewFrameEventHandler(Capturando);

                    MiCamara.Start();
                }
                else
                {
                    MessageBox.Show("El índice de resolución seleccionado está fuera de rango.");
                }
            }
        }


        private void Capturando(object sender, NewFrameEventArgs e)
        {
            Bitmap Image = (Bitmap)e.Frame.Clone();
            pictureBox1.Image = Image;
        }

        private void CerrarCamara()
        {
            if (MiCamara != null && MiCamara.IsRunning)
            {
                MiCamara.SignalToStop();
                MiCamara = null;
            }
        }


        //Resto del codigo
        private void FormularioIngreso_Load(object sender, EventArgs e)
        {
            CargarDispositivos();

            lblTipo.Visible = true;
            cbTipo.Visible = true;
            cbSectorVisitante.Visible = true;
            lblArea.Visible = true;
            cbArea.Visible = true;
            cbSubArea.Visible = true;
            lblSubArea.Visible = true;
            ibSacarFoto.Visible = true;

            lblDni.Visible = false;
            txtDNI.Visible = false;
            txtSector.Visible = false;
            lblTarjeta.Visible = false;
            nudNroTarjeta.Visible = false;
            lblMotivo.Visible = false;
            cbMotivo.Visible = false;
            lblEMotivo.Visible = false;
            txtEMotivo.Visible = false;




            txtFecha.Text = fechaActual;
            txtHora.Text = horaactual;
            UrlImage = @"";

            //Tipos
            cbTipo.Items.Add("INSPECCION");
            cbTipo.Items.Add("PROVEEDORES");
            cbTipo.Items.Add("CLIENTES");
            cbTipo.Items.Add("ENTREVISTA");
            //Sector
            cbSectorVisitante.Items.Add("PLANTA");
            cbSectorVisitante.Items.Add("ADMINISTRACION");


        }
        private void CamShot_NewFrameCaptured(object sender, NewFrameEventArgs eventArgs)
        {
            // Mostrar el nuevo fotograma en el PictureBox
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void cbSector_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbArea.Items.Clear();

            if (cbSectorVisitante.SelectedItem.ToString() == "ADMINISTRACION")
            {

                cbSubArea.Visible = false;
                lblSubArea.Visible = false;
                //AreaAdministracion
                cbArea.Items.Add("POSTVENTA");
                cbArea.Items.Add("COMPRAS");
                cbArea.Items.Add("LOGISTICA");
                cbArea.Items.Add("INGENIERIA");
                cbArea.Items.Add("RECURSOS HUMANOS");
                cbArea.Items.Add("OTROS");


            }
            else
            {
                cbSubArea.Visible = true;
                lblSubArea.Visible = true;
                //Area
                cbArea.Items.Add("DISTRIBUCION");
                cbArea.Items.Add("POTENCIA");
            }
        }

        private void cbArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSubArea.Items.Clear();

            if (cbArea.SelectedItem.ToString() == "POTENCIA")
            {
                //Potencia
                cbSubArea.Items.Add("BOBINADO");
                cbSubArea.Items.Add("MONTAJE");
                cbSubArea.Items.Add("CONEXIONADO");
                cbSubArea.Items.Add("DESPACHO");
                cbSubArea.Items.Add("ESTABILIZADORA");
                cbSubArea.Items.Add("DEPOSITO");
                cbSubArea.Items.Add("SUPERVISORES");
                cbSubArea.Items.Add("CARPINTERIA");
                cbSubArea.Items.Add("OTROS");
            }
            else
            {
                //Distribucion
                cbSubArea.Items.Add("BOBINADO");
                cbSubArea.Items.Add("MONTAJE");
                cbSubArea.Items.Add("CONEXIONADO");
                cbSubArea.Items.Add("ENCUBADO");
                cbSubArea.Items.Add("LABORATORIO");
                cbSubArea.Items.Add("DESPACHO");
                cbSubArea.Items.Add("HERRERIA");
                cbSubArea.Items.Add("PINTURA");
            }
        }



        [Obsolete]
        private void ibAgregar_Click(object sender, EventArgs e)
        {
            bool SeInserto = false;

            try
            {
                if (lblTitulo.Text == "Ingresar Dni de visitante")
                {

                    if (!File.Exists(rutaBase + "IngresosVisitante.dbf"))
                    {
                        writer = new DBFWriter(rutaBase + "IngresosVisitante.dbf");

                        DBFField[] fields = new DBFField[]
                        {
                            new DBFField("DNI", NativeDbType.Char, 10),
                            new DBFField("Apellido", NativeDbType.Char, 30),
                            new DBFField("Nombres", NativeDbType.Char, 40),
                            new DBFField("TipoVisita", NativeDbType.Char, 15),
                            new DBFField("Sector", NativeDbType.Char, 15),
                            new DBFField("Area", NativeDbType.Char, 15),
                            new DBFField("SubArea", NativeDbType.Char, 20),
                            new DBFField("Hora", NativeDbType.Char, 10),
                            new DBFField("Fecha", NativeDbType.Char, 10),
                        };
                        writer.Fields = fields;
                    }
                    else
                    {
                        writer = new DBFWriter(rutaBase + "IngresosVisitante.dbf");

                    }

                    writer.WriteRecord(nudFiltro.Value.ToString(), tbxApellido.Text, tbxNombres.Text, cbTipo.SelectedItem, cbSectorVisitante.SelectedItem, cbArea.SelectedItem, cbSubArea.SelectedItem ?? "", txtHora.Text, txtFecha.Text);
                    MessageBox.Show("Registro agregado con éxito");


                }
                else
                {
                    AgregarIngresoEmpleado();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar registros en el archivo DBF: " + ex.Message);
            }
            finally
            {
                writer.Close();
            }

        }


        private void ibSacarFoto_Click(object sender, EventArgs e)
        {

            if (nudFiltro.Value != 0)
            {

                try
                {

                    CerrarCamara();
                    DateTime now = DateTime.Now;

                    string nombreArchivo = string.Format($"{nudFiltro.Value.ToString()}.jpg", now);

                    string rutaCompleta = Path.Combine(rutacarpetaVisitantes, nombreArchivo);
                    pictureBox1.Image.Save(rutaCompleta, ImageFormat.Jpeg);

                }
                catch (Exception)
                {

                    MessageBox.Show("No hay ninguna imagen para capturar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Primero tiene que rellenar los datos");
            }
        }

        private void FormularioIngreso_FormClosing(object sender, FormClosingEventArgs e)
        {
            CerrarCamara();
        }




        private void ibEscanear_Click(object sender, EventArgs e)
        {

            // Mostrar un cuadro de diálogo para que el usuario ingrese la cadena
            string input = Microsoft.VisualBasic.Interaction.InputBox("Escanee el DNI", "Escanear", "");

            // Verificar si se ingresó una cadena
            if (!string.IsNullOrEmpty(input))
            {
                // Patrón para encontrar el apellido, nombre y DNI
                string pattern = "\"([^\"]+)\"([^\"]+)\"[FM]\"([^\"]+)\"";

                // Realizar coincidencias utilizando expresiones regulares
                MatchCollection matches = Regex.Matches(input, pattern);

                // Iterar sobre las coincidencias y mostrar los resultados
                foreach (Match match in matches)
                {
                    tbxApellido.Text = match.Groups[1].Value;
                    tbxNombres.Text = match.Groups[2].Value;
                    nudFiltro.Value = Convert.ToInt32(match.Groups[3].Value);



                }
            }
            else
            {
                MessageBox.Show("No se ingresó ninguna cadena.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ibBuscar_Click(object sender, EventArgs e)
        {
            int dniOLegajoABuscar = (int)nudFiltro.Value;
            int indexRegistromodificar = 0;

            try
            {

                if (lblTitulo.Text == "Ingresar Dni de visitante")
                {
                    indexRegistromodificar = ABM.GetindiceRegistro(originalFilePathVisitante, nudFiltro.Value.ToString(), 0);
                    using (var reader = new DotNetDBF.DBFReader(originalFilePathVisitante))
                    {
                        int currentIndex = 0;
                        object[] record;
                        while ((record = reader.NextRecord()) != null)
                        {
                            if (currentIndex == indexRegistromodificar)
                            {
                                nudFiltro.Value = Convert.ToInt32(record[0].ToString());
                                tbxApellido.Text = record[1].ToString();
                                tbxNombres.Text = record[2].ToString();
                                cbTipo.SelectedItem = record[3].ToString();
                                cbSectorVisitante.SelectedItem = record[4].ToString();
                                cbArea.SelectedItem = record[5].ToString();
                                cbSubArea.SelectedItem = record[6].ToString();
                                txtFecha.Text = record[7].ToString();
                                txtHora.Text = record[8].ToString();

                                string[] archivosImagen = Directory.GetFiles(rutacarpetaVisitantes, nudFiltro.Value.ToString() + ".jpg");

                                if (archivosImagen.Length > 0)
                                {
                                    pictureBox1.Image = Image.FromFile(archivosImagen[0]);
                                    CerrarCamara();
                                }
                            }

                            currentIndex++;
                        }
                    }
                }
                else
                {
                    BuscarEmpleado((int)nudFiltro.Value);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error al intentar de acceder a los archivos");
            }
        }

        private void ibTarjeta_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Ingresar Legajo del empleado";
            lblTipo.Visible = false;
            cbTipo.Visible = false;
            cbSectorVisitante.Visible = false;
            lblArea.Visible = false;
            cbArea.Visible = false;
            cbSubArea.Visible = false;
            lblSubArea.Visible = false;
            ibSacarFoto.Visible = false;


            lblDni.Visible = true;
            txtDNI.Visible = true;
            txtSector.Visible = true;
            lblTarjeta.Visible = true;
            nudNroTarjeta.Visible = true;
            lblMotivo.Visible = true;
            cbMotivo.Visible = true;

            cbMotivo.Items.Clear();

            cbMotivo.Items.Add("SIN TARJETA (OLVIDO)");
            cbMotivo.Items.Add("SIN TARJETA (NUEVO)");
            cbMotivo.Items.Add("EXTRAVIO");
            cbMotivo.Items.Add("ROBO O HURTO");
            cbMotivo.Items.Add("OTROS");
        }
        private void BuscarEmpleado(int nrolegajo)
        {
            string carpetaImagenes = "R:\\Fotos Mate\\";

            DataTable datatable = new DataTable();
            DatabaseLoader loader = new DatabaseLoader();
            datatable = loader.LoadData("Empleados");


            DataRow[] rows = datatable.Select("XLEG = '" + nrolegajo + "'");

            if (rows.Length > 0)
            {
                // Obtener los valores del registro encontrado
                nudNroTarjeta.Value = Convert.ToInt32(rows[0]["XTARP"]);
                tbxApellido.Text = rows[0]["XAPE"].ToString();
                tbxNombres.Text = rows[0]["XNOM"].ToString();
                txtDNI.Text = rows[0]["XDOC"].ToString();
                txtSector.Text = rows[0]["XSEC"].ToString();
                cbMotivo.SelectedItem = string.Empty;
                txtEMotivo.Text = string.Empty;

                string[] archivosImagen = Directory.GetFiles(carpetaImagenes, nudFiltro.Value + ".*");

                if (archivosImagen.Length > 0)
                {
                    CerrarCamara();
                    pictureBox1.Image = Image.FromFile(archivosImagen[0]);
                }

            }


        }
        private void AgregarIngresoEmpleado()
        {


            if (!File.Exists(rutaBase + "IngresosEmpleadosSinTarjeta.dbf"))
            {
                writer = new DBFWriter(rutaBase + "IngresosEmpleadosSinTarjeta.dbf");


                DBFField[] fields = new DBFField[]
                {
                            new DBFField("Legajo", NativeDbType.Numeric, 10),
                            new DBFField("Apellido", NativeDbType.Char, 30),
                            new DBFField("Nombre", NativeDbType.Char, 40),
                            new DBFField("DNI", NativeDbType.Char, 10),
                            new DBFField("NroTarjeta", NativeDbType.Numeric, 12),
                            new DBFField("Sector", NativeDbType.Char, 10),
                            new DBFField("Fecha", NativeDbType.Char, 10),
                            new DBFField("HoraIngre", NativeDbType.Char, 20),
                            new DBFField("HoraSali", NativeDbType.Char, 20),
                            new DBFField("Motivo", NativeDbType.Char, 30),
                            new DBFField("Explayo", NativeDbType.Char, 50),


                };
                writer.Fields = fields;
            }
            else
            {
                writer = new DBFWriter(rutaBase + "IngresosEmpleadosSinTarjeta.dbf");

            }

            writer.WriteRecord((int)nudFiltro.Value, tbxApellido.Text, tbxNombres.Text, txtDNI.Text, (int)nudNroTarjeta.Value, txtSector.Text, ABM.getFechaActual(), ABM.getHoraActual(), "", cbMotivo.SelectedItem, txtEMotivo.Text ?? "");
            MessageBox.Show("Registro agregado con exito");

        }

        private void cbMotivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMotivo.SelectedItem == "OTROS")
            {
                lblEMotivo.Visible = true;
                txtEMotivo.Visible = true;
            }
            else
            {
                lblEMotivo.Visible = false;
                txtEMotivo.Visible = false;
            }
        }
    }
}

