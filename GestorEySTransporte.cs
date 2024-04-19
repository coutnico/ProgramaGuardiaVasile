using AForge.Video.DirectShow;
using AForge.Video;
using CapturarIngresos.Models;
using DotNetDBF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using Microsoft.VisualBasic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Data.SqlTypes;

namespace CapturarIngresos
{
    public partial class GestorEySTransporte : Form
    {
        private FilterInfoCollection MisDispositivos;
        private VideoCaptureDevice MiCamara;

        private string ModoAcceso = null;

        private DataTable TablaChoferes;

        DBFWriter writer;
        DatabaseLoader loader = new DatabaseLoader();

        bool Internos = false;
        bool Externos = false;

        string rutaBase = "R:\\sistemas_nico\\CapturarIngresosVMate\\database\\";

        string rutafotos = "R:\\sistemas_nico\\CapturarIngresosVMate\\ImagenesCapturadas\\FotoChoferesExternos\\";


        private string fechaActual = DateTime.Today.ToString("dd/MM/yyyy");
        private string horaactual = DateTime.Now.ToString("HH:mm");

        string[] archivosImagenFrente;
        string[] archivosImagenDorso;
        private bool SesacoFoto;

        public GestorEySTransporte(string modo)
        {
            InitializeComponent();

            this.ModoAcceso = modo;

            if (ModoAcceso == "Entrada")
            {
                lblIngreso.Text = "Entrada de transporte";
            }
            else if (ModoAcceso == "Salida")
            {
                lblIngreso.Text = "Salida de transporte";
            }

        }

        //Inicializacion de WeCam
        private async Task CargarDispositivosAsync()
        {
            await Task.Run(() =>
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
            });
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



        private void ibAgregar_Click(object sender, EventArgs e)
        {


            if (Internos == true && Externos == false)
            {

                try
                {
                    string nombreArchivo = (ModoAcceso == "Entrada") ? "TransportesInternosEntrada.dbf" : "TransportesInternosSalida.dbf";

                    if (!File.Exists(rutaBase + nombreArchivo))
                    {
                        writer = new DBFWriter(rutaBase + nombreArchivo);

                        DBFField[] fields = new DBFField[]
                        {
                        new DBFField("Transpo", NativeDbType.Char, 40),
                        new DBFField("Chofer", NativeDbType.Char, 50),
                        new DBFField("Modalida", NativeDbType.Char, 20),
                        new DBFField("Vehi1", NativeDbType.Char, 40),
                        new DBFField("Vehi2", NativeDbType.Char, 40),
                        new DBFField("Vehi3", NativeDbType.Char, 40),
                        new DBFField("Observa", NativeDbType.Char, 100),
                        new DBFField("Dni", NativeDbType.Char, 10),
                        new DBFField("Fecha", NativeDbType.Char, 10),
                        new DBFField("Hora", NativeDbType.Char, 20)
                        };
                        writer.Fields = fields;
                    }
                    else
                    {
                        writer = new DBFWriter(rutaBase + nombreArchivo);
                    }

                    if (cbChoferes.SelectedItem != null)
                    {
                        writer.WriteRecord(txtTransportista.Text, cbChoferes.SelectedItem, cbModalidad.SelectedItem, cbVehiculos.SelectedItem, txtVehiculo2.Text ?? "", txtVehiculo3.Text ?? "", txtObservacion.Text ?? "", txtDni.Text, txtFecha.Text, txtHora.Text);
                        MessageBox.Show("Registro agregado exitosamente");

                    }

                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
                finally
                {
                    writer.Close();
                }
            }
            else if (Externos == true && Internos == false)
            {
                try
                {
                    string nombreArchivo = (ModoAcceso == "Entrada") ? "TransportesExternosEntrada.dbf" : "TransportesExternosSalida.dbf";

                    if (!File.Exists(rutaBase + nombreArchivo))
                    {
                        writer = new DBFWriter(rutaBase + nombreArchivo);

                        DBFField[] fields = new DBFField[]
                        {
                        new DBFField("Transpo", NativeDbType.Char, 40),
                        new DBFField("Chofer", NativeDbType.Char, 50),
                        new DBFField("Modalida", NativeDbType.Char, 20),
                        new DBFField("Vehi1", NativeDbType.Char, 40),
                        new DBFField("Vehi2", NativeDbType.Char, 40),
                        new DBFField("Vehi3", NativeDbType.Char, 40),
                        new DBFField("Observa", NativeDbType.Char, 100),
                        new DBFField("Dni", NativeDbType.Char, 10),
                        new DBFField("Fecha", NativeDbType.Char, 10),
                        new DBFField("Hora", NativeDbType.Char, 20),
                        new DBFField("Cedula1", NativeDbType.Char, 5),
                        new DBFField("Cedula2", NativeDbType.Char, 5),
                        new DBFField("RUTA", NativeDbType.Char, 5),
                        new DBFField("Seguros", NativeDbType.Char, 5),
                        new DBFField("VTVRTO", NativeDbType.Char, 5),
                        new DBFField("ART", NativeDbType.Char, 5),
                        new DBFField("Telefono", NativeDbType.Char, 15)
                        };
                        writer.Fields = fields;
                    }
                    else
                    {
                        writer = new DBFWriter(rutaBase + nombreArchivo);
                    }

                    if (!string.IsNullOrEmpty(txtChofer.Text))
                    {
                        writer.WriteRecord(txtTransportista.Text, txtChofer.Text, cbModalidad.SelectedItem, txtVehiculo1.Text, txtVehiculo2.Text ?? "", txtVehiculo3.Text ?? "", txtObservacion.Text ?? "", txtDni.Text, txtFecha.Text, txtHora.Text, cbCedula1.Checked ? "Si":"No", cbCedula2.Checked ? "Si" : "No", cbRUTA.Checked ? "Si" : "No", cbSeguros.Checked ? "Si" : "No", cbVTVRTO.Checked ? "Si" : "No", cbART.Checked ? "Si" : "No", nudTelefono.Value.ToString());
                        MessageBox.Show("Registro agregado exitosamente");

                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
                finally
                {
                    writer.Close();
                }
            }


        }




        [Obsolete]
        private void GestorEySTransporte_Load(object sender, EventArgs e)
        {

            txtFecha.Text = fechaActual;
            txtHora.Text = horaactual;
            txtDni.Text = string.Empty;


            //Cargar Choferes 
            DataTable dataTable = new DataTable();

            dataTable = loader.FiltrarDadosdeBaja(dataTable);

            dataTable = loader.FiltrarChoferes(dataTable);

            TablaChoferes = dataTable;

            foreach (DataRow row in dataTable.Rows)
            {
                string nombreCompleto = row["XAPE"].ToString() + " " + row["XNOM"].ToString();
                string legajo = row["XLEG"].ToString();

                string item = $"{nombreCompleto} {legajo}";
                cbChoferes.Items.Add(item);
            }

            //CargarVehiculos
            DataTable vehiculos = loader.LoadData("Vehiculos");


            foreach (DataRow row in vehiculos.Rows)
            {
                string fechavtv = row["PVTV"].ToString().Split(' ')[0];

                string fechaseguro = row["PSEG"].ToString().Split(' ')[0];

                DateTime FechaVTV = DateTime.Parse(fechavtv);
                DateTime FechaSeguro = DateTime.Parse(fechaseguro);


                if (FechaVTV >= DateTime.Parse(ABM.getFechaActual()) && FechaSeguro >= DateTime.Parse(ABM.getFechaActual()))
                {
                    string modelo = row["PMOD"].ToString().ToUpper();
                    string patente = row["PPAT"].ToString().ToUpper();

                    cbVehiculos.Items.Add(modelo + " " + patente);
                }

            }


        }

        private void ibInterno_Click(object sender, EventArgs e)
        {

            Externos = false;
            Internos = true;

            cbModalidad.Items.Clear();

            cbModalidad.Items.Add("SERVICIO");
            cbModalidad.Items.Add("MONTAJE");
            cbModalidad.Items.Add("PROVEEDORES");
            cbModalidad.Items.Add("PILARICA");
            cbModalidad.Items.Add("SUPERI");
            cbModalidad.Items.Add("VENTA");

            txtTransportista.Text = "VASILE & CIA";
            txtTransportista.ReadOnly = true;
            cbChoferes.Visible = true;
            txtChofer.Visible = false;
            txtDni.ReadOnly = true;
            ibEscanear.Visible = false;
            cbVehiculos.Visible = true;
            ibEscanearRegistro.Visible = false;
            panelDocumentacion.Visible = false;
            txtDni.ReadOnly = true;


            pictureBox1.Size = new System.Drawing.Size(310, 321);
            pictureBox1.Location = new System.Drawing.Point(38, 118);

            lblEscaneado.Visible = false;
            pbFrente.Visible = false;
            pbDorso.Visible = false;
            ibSacarFotoFrente.Visible = false;
            lblTelefono.Visible = false;
            nudTelefono.Visible = false;

            CerrarCamara();

            pictureBox1.Image = pictureBox1.InitialImage;

        }

        private async void ibExterno_Click(object sender, EventArgs e)
        {
            Internos = false;
            Externos = true;



            cbModalidad.Items.Clear();
            cbModalidad.Items.Add("CLIENTE");
            txtTransportista.Text = "";
            txtTransportista.ReadOnly = false;
            cbChoferes.Visible = false;
            txtChofer.Visible = true;
            txtDni.ReadOnly = false;
            ibEscanear.Visible = true;
            cbVehiculos.Visible = false;
            ibEscanearRegistro.Visible = true;
            panelDocumentacion.Visible = true;


            txtDni.ReadOnly = false;

            pictureBox1.Size = new System.Drawing.Size(249, 262);
            pictureBox1.Location = new System.Drawing.Point(58, 73);
            pbFrente.Visible = true;
            pbDorso.Visible = true;
            ibSacarFotoFrente.Visible = true;
            lblTelefono.Visible = true;
            nudTelefono.Visible = true;

           await CargarDispositivosAsync();


            if (ModoAcceso == "Salida")
            {

                ibSacarFotoFrente.Visible = false;
                AbrirVentanaEmergente();
            }

        }

        private void cbChoferes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cadenaCompleta = cbChoferes.SelectedItem.ToString();
            string[] partes = cadenaCompleta.Split(' ');
            string numerolegajo = partes[partes.Length - 1];

            foreach (DataRow choferes in TablaChoferes.Rows)
            {
                if (numerolegajo == choferes["XLEG"].ToString())
                {
                    txtDni.Text = choferes["XDOC"].ToString();
                }
            }
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
                    string apellido = match.Groups[1].Value;
                    string nombre = match.Groups[2].Value;

                    txtChofer.Text = apellido + " " + nombre;
                    txtDni.Text = match.Groups[3].Value.ToString();



                }
            }
            else
            {
                MessageBox.Show("No se ingresó ninguna cadena.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ibEscanearRegistro_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDni.Text) && SesacoFoto == true)
            {
                EscanerDocumento escaner = new EscanerDocumento(txtDni.Text);
                DialogResult resultado = escaner.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    lblEscaneado.Visible = true;

                    string carpetaImagenes = "R:\\sistemas_nico\\CapturarIngresosVMate\\ImagenesCapturadas\\LicenciasDeConducir";

                    archivosImagenFrente = Directory.GetFiles(carpetaImagenes, txtDni.Text + "Frente.jpg");
                    archivosImagenDorso = Directory.GetFiles(carpetaImagenes, txtDni.Text + "Dorso.jpg");


                    pbFrente.Image = Image.FromFile(archivosImagenFrente[0]);
                    pbDorso.Image = Image.FromFile(archivosImagenDorso[0]);
                }
                else
                {

                }


            }
            else
            {
                MessageBox.Show("Completar la informacion del transporte");
            }
        }

        private void pbFrente_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("explorer.exe", "\"" + archivosImagenFrente[0] + "\"");

            }
            catch (Exception)
            {

                MessageBox.Show("Error al abrir imagen");
            }
        }

        private void pbDorso_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("explorer.exe", "\"" + archivosImagenDorso[0] + "\"");

            }
            catch (Exception)
            {

                MessageBox.Show("Error al abrir imagen");
            }
        }

        private void GestorEySTransporte_FormClosing(object sender, FormClosingEventArgs e)
        {
            CerrarCamara();
        }

        private void ibSacarFotoFrente_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtDni.Text))
                {
                    CerrarCamara();
                    DateTime now = DateTime.Now;

                    string nombreArchivo = string.Format($"{txtDni.Text}.jpg", now);

                    string fotocapturada = Path.Combine(rutafotos, nombreArchivo);

                    pictureBox1.Image.Save(fotocapturada, ImageFormat.Jpeg);

                    SesacoFoto = true;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("No hay ninguna imagen para capturar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void AbrirVentanaEmergente()
        {
            string originalFilePathEntradas = "R:\\sistemas_nico\\CapturarIngresosVMate\\database\\TransportesExternosEntrada.dbf";
            string carpetaImagenes = "R:\\sistemas_nico\\CapturarIngresosVMate\\ImagenesCapturadas\\FotoChoferesExternos";
            string dniIngresado = Interaction.InputBox("Ingresar DNI del chofer:", "Ingresar DNI");

            if (!string.IsNullOrEmpty(dniIngresado))
            {
                int indexRegistromodificar = 0;
                DateTime fechaactual = DateTime.Parse(ABM.getFechaActual());
                DateTime fecharegistro;
                indexRegistromodificar = ABM.GetindiceRegistro(originalFilePathEntradas, dniIngresado, 7);
                using (var reader = new DBFReader(originalFilePathEntradas))
                {
                    int currentIndex = 0;
                    object[] record;
                    while ((record = reader.NextRecord()) != null)
                    {
                        if (currentIndex == indexRegistromodificar)
                        {
                            fecharegistro = DateTime.Parse(record[8].ToString());

                            if (fechaactual <= fecharegistro)
                            {
                                txtTransportista.Text = record[0].ToString();
                                txtChofer.Text = record[1].ToString();
                                cbModalidad.SelectedItem = record[2].ToString();
                                txtVehiculo1.Text = record[3].ToString();
                                txtVehiculo2.Text = record[4].ToString();
                                txtVehiculo3.Text = record[5].ToString();
                                txtObservacion.Text = record[6].ToString();
                                txtDni.Text = record[7].ToString();
                                txtFecha.Text = ABM.getFechaActual();
                                txtHora.Text = ABM.getHoraActual();
                                cbCedula1.Checked = (record[10].ToString() == "Si") ? true : false;
                                cbCedula2.Checked = (record[11].ToString() == "Si") ? true : false;
                                cbRUTA.Checked = (record[12].ToString() == "Si") ? true : false;
                                cbSeguros.Checked = (record[13].ToString() == "Si") ? true : false;
                                cbVTVRTO.Checked = (record[14].ToString() == "Si") ? true : false;
                                cbART.Checked = (record[15].ToString() == "Si") ? true : false;
                                nudTelefono.Value = Convert.ToInt64(record[16].ToString());


                                string[] archivosImagen = Directory.GetFiles(carpetaImagenes, dniIngresado + ".jpg");
                                if (archivosImagen.Length > 0)
                                {
                                    CerrarCamara();
                                    pictureBox1.Image = Image.FromFile(archivosImagen[0]);
                                }
                            }
                     
                        }



                        currentIndex++;
                    }
                }
            }
            else
            {
                MessageBox.Show("No se ingresó ningún valor.");
            }
        }


    }
}
