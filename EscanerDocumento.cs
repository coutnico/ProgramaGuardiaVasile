using AForge.Video.DirectShow;
using AForge.Video;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace CapturarIngresos
{
    public partial class EscanerDocumento : Form
    {
        private FilterInfoCollection MisDispositivos;
        private VideoCaptureDevice MiCamara;
        bool SacoprimerFoto = false;
        string DniRecibido;
        string rutaCompletaFrente;
        string rutaCompletaDorso;
        string rutafotos = "R:\\sistemas_nico\\CapturarIngresosVMate\\ImagenesCapturadas\\LicenciasDeConducir\\";
        public EscanerDocumento(string dni)
        {
            InitializeComponent();
            this.DniRecibido = dni;
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
                        if (MisDispositivos[i].Name.ToString() == "USB CAMERA")
                            MiCamara = new VideoCaptureDevice(MisDispositivos[i].MonikerString);
                    }

                    MiCamara.NewFrame += new NewFrameEventHandler(Capturando);
                    MiCamara.Start();
                    //VideoCapabilities[] resoluciones = MiCamara.VideoCapabilities;

                    //int indiceResolucion = 2;
                    //if (indiceResolucion >= 0 && indiceResolucion < resoluciones.Length)
                    //{
                    //    MiCamara.VideoResolution = resoluciones[indiceResolucion];


                    //}
                    //else
                    //{
                    //    MessageBox.Show("El índice de resolución seleccionado está fuera de rango.");
                    //}
                }
            });
        }

        private void Capturando(object sender, NewFrameEventArgs e)
        {
            Bitmap Image = (Bitmap)e.Frame.Clone();

            if (!SacoprimerFoto)
            {
                pictureBox1.Image = Image;
            }
            else
            {
                pictureBox2.Image = Image;
            }
        }

        private void CerrarCamara()
        {
            if (MiCamara != null && MiCamara.IsRunning)
            {
                MiCamara.SignalToStop();
                MiCamara = null;
            }
        }

        private async void EscanerDocumento_Load(object sender, EventArgs e)
        {
            await CargarDispositivosAsync();
        }


        private void EscanerDocumento_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MiCamara != null && MiCamara.IsRunning)
            {
                this.DialogResult = DialogResult.Cancel;
                CerrarCamara();
            }
        }

        private void ibSacarFotoFrente_Click(object sender, EventArgs e)
        {
            if (DniRecibido != null)
            {

                try
                {

                    CerrarCamara();
                    DateTime now = DateTime.Now;

                    string nombreArchivo = string.Format($"{DniRecibido}Frente.jpg", now);

                    rutaCompletaFrente = Path.Combine(rutafotos, nombreArchivo);

                    SacoprimerFoto = true;
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

        private void ibSacarFotoDorso_Click(object sender, EventArgs e)
        {
            if (DniRecibido != null)
            {

                try
                {

                    CerrarCamara();
                    DateTime now = DateTime.Now;

                    string nombreArchivo = string.Format($"{DniRecibido}Dorso.jpg", now);

                    rutaCompletaDorso = Path.Combine(rutafotos, nombreArchivo);

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

        private async void ibRefresh_Click(object sender, EventArgs e)
        {
            if (SacoprimerFoto)
            {
                await CargarDispositivosAsync();
                pictureBox2.Refresh();
            }
        }

        private void ibAceptar_Click(object sender, EventArgs e)
        {


            pictureBox1.Image.Save(rutaCompletaFrente, ImageFormat.Jpeg);
            pictureBox2.Image.Save(rutaCompletaDorso, ImageFormat.Jpeg);



            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
