using CapturarIngresos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapturarIngresos
{
    public partial class Login : Form
    {
        DatabaseLoader loader = new DatabaseLoader();
        public event EventHandler InicioSesionExitoso;


        public Login()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x122, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x122, 0xf012, 0);
        }

        private void ibIniciarSesion_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            dataTable = loader.LoadData("Login");

            string nombreusuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            DataRow[] coincidencias = dataTable.Select($"Usuario = '{nombreusuario}' AND Contraseña = '{contraseña}'");

            try
            {
                if (coincidencias.Length > 0)
                {

                    int permiso = (int)coincidencias[0]["Permiso"];
          
                    UsuarioActual.NombreUsuario = nombreusuario;
                    UsuarioActual.Contraseña = contraseña;
                    UsuarioActual.Permiso = permiso;

                    this.DialogResult = DialogResult.OK;

                    this.Close();

                }
                else
                {
                    MessageBox.Show("Nombre de usuario o contraseña incorrectos");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"{ex.Message}");
            }
        }
    }
}
