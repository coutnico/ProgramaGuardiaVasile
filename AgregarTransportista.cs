using AForge.Video;
using AForge.Video.DirectShow;
using CapturarIngresos.Models;
using DotNetDBF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CapturarIngresos
{
    public partial class AgregarTransportista : Form
    {
        string fechaActual = DateTime.Today.ToString("dd/MM/yyyy");
        string horaactual = DateTime.Now.ToString("HH:mm");
        static string conexionString = "server=192.168.1.180; database=AppIngresos; user=sa; password=Vasile123";
        SqlConnection conexion = new SqlConnection(conexionString);

        DBFWriter writer;

        static bool SesacoFoto;

        string rutacarpeta = "Z:\\CARLOS SISTEMA\\sistemas_nico\\CapturarIngresosVMate\\ImagenesCapturadas\\Choferes";
        string originalFilePath = "Z:\\CARLOS SISTEMA\\sistemas_nico\\CapturarIngresosVMate\\database\\";


        private FilterInfoCollection MisDispositivos;
        private VideoCaptureDevice MiCamara;

        public AgregarTransportista()
        {

            InitializeComponent();
        }
        //Inicializacion de WeCam
        private void CargarDispositivos()
        {
            MisDispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (MisDispositivos.Count > 0)
            {
                MiCamara = new VideoCaptureDevice(MisDispositivos[0].MonikerString);

                VideoCapabilities[] resoluciones = MiCamara.VideoCapabilities;

                int indiceResolucion = 2;
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


        private void AgregarTransportista_Load(object sender, EventArgs e)
        {
            txtFecha.Text = fechaActual;
            CargarDispositivos();
        }

        private void ibAgregar_Click(object sender, EventArgs e)
        {
            bool SeInserto;
            if (SesacoFoto)
            {
                try
                {
                    if (!File.Exists(originalFilePath + "Choferes.dbf"))
                    {
                        writer = new DBFWriter(originalFilePath + "Choferes.dbf");


                        DBFField[] fields = new DBFField[]
                        {
                            new DBFField("Legajo", NativeDbType.Numeric, 10),
                            new DBFField("NombreComp", NativeDbType.Char, 50),
                            new DBFField("NroTarjeta", NativeDbType.Numeric, 12),
                            new DBFField("Nregistro", NativeDbType.Numeric, 12),
                            new DBFField("DNI", NativeDbType.Char, 10),
                            new DBFField("Fecha", NativeDbType.Char, 10),

                        };
                        writer.Fields = fields;
                    }
                    else
                    {
                        writer = new DBFWriter(originalFilePath + "Choferes.dbf");

                    }

                    writer.WriteRecord((int)nudLegajo.Value, txtNombre.Text, (int)nudNrotarjeta.Value, (int)nudRegistro.Value, txtDNI.Text, txtFecha.Text);
                    SeInserto = true;

                    if (SeInserto)
                    {
                        MessageBox.Show("Registro agregado");
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar el registro");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar registro");
                }
                finally
                {
                    writer.Close();
                }
            }
            else
            {
                MessageBox.Show("Por favor sacar foto al chofer");
            }
        }
        private void ibSacarFoto_Click(object sender, EventArgs e)
        {
            try
            {
                if (nudLegajo.Value != 0)
                {

                    CerrarCamara();
                    DateTime now = DateTime.Now;

                    string nombreArchivo = string.Format($"{nudLegajo.Value.ToString()}.jpg", now);

                    string rutaCompleta = Path.Combine(rutacarpeta, nombreArchivo);
                    pictureBox1.Image.Save(rutaCompleta, ImageFormat.Jpeg);

                    SesacoFoto = true;

                }
                else
                {
                    MessageBox.Show("Cargar datos primero");
                }

            }
            catch (Exception)
            {

                MessageBox.Show("No hay ninguna imagen para capturar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void AgregarTransportista_FormClosing(object sender, FormClosingEventArgs e)
        {
            CerrarCamara();
        }



        private void lblHora_Click(object sender, EventArgs e)
        {

        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }

        private void txtFecha_TextChanged(object sender, EventArgs e)
        {

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

                    txtNombre.Text = apellido + " " + nombre;
                    txtDNI.Text = match.Groups[3].Value;



                }
            }
            else
            {
                MessageBox.Show("No se ingresó ninguna cadena.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
