using CapturarIngresos.Models;
using DotNetDBF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapturarIngresos
{
    public partial class IngresarSalida : Form
    {
        string horaactual = DateTime.Now.ToString("HH:mm");
        string fechaActual = DateTime.Today.ToString("dd/MM/yyyy");


        string originalFilePathConTarjeta = "R:\\sistemas_nico\\CapturarIngresosVMate\\database\\IngresosEmpleados.dbf";
        string originalFilePathSinTarjeta = "R:\\sistemas_nico\\CapturarIngresosVMate\\database\\IngresosEmpleadosSinTarjeta.dbf";
        string newFilePath = "R:\\sistemas_nico\\CapturarIngresosVMate\\database\\temp10.dbf";
        string carpetaImagenes = "R:\\Fotos Mate\\";

        private bool Tarjeta;


        public IngresarSalida(bool conTarjeta, int legajo, string apellido, string nombre, int numerotarjeta, string dni, string sector, string fecha, string hora)
        {
            InitializeComponent();
            nudLegajo.Value = legajo;
            tbxApellido.Text = apellido;
            tbxNombres.Text = nombre;
            nudNroTarjeta.Value = numerotarjeta;
            txtDNI.Text = dni;
            txtSectorEmpleado.Text = sector;
            txtFecha.Text = fecha;
            txtHoraIngreso.Text = hora;
            lblMotivo.Visible = false;
            txtMotivo.Visible = false;
            lblEMotivo.Visible = false;
            txtEMotivo.Visible = false;

            this.Tarjeta = conTarjeta;
        }
        public IngresarSalida(bool conTarjeta, int legajo, string apellido, string nombre, int numerotarjeta, string dni, string sector, string fecha, string hora, string motivo, string explayo)
        {
            InitializeComponent();
            nudLegajo.Value = legajo;
            tbxApellido.Text = apellido;
            tbxNombres.Text = nombre;
            nudNroTarjeta.Value = numerotarjeta;
            txtDNI.Text = dni;
            txtSectorEmpleado.Text = sector;
            txtFecha.Text = fecha;
            txtHoraIngreso.Text = hora;

            lblMotivo.Visible = true;
            txtMotivo.Visible = true; txtMotivo.Text = motivo;
            lblEMotivo.Visible = true;
            txtEMotivo.Visible = true; txtEMotivo.Text = explayo;

            this.Tarjeta = conTarjeta;


        }

        private void IngresarSalida_Load(object sender, EventArgs e)
        {
            string[] archivosImagen = Directory.GetFiles(carpetaImagenes, nudLegajo.Value + ".*");

            pictureBox1.Image = Image.FromFile(archivosImagen[0]);

            txtHoraSalida.Text = horaactual;
        }

        [Obsolete]
        private void ibAgregar_Click(object sender, EventArgs e)
        {
            int registroSustituir;

            if (Tarjeta)
            {


                registroSustituir = ABM.GetindiceRegistro(originalFilePathConTarjeta, nudLegajo.Value.ToString(), 0, 6);

                if (registroSustituir == -1 || fechaActual != txtFecha.Text)
                {
                    MessageBox.Show("La fecha del registro no es la misma del dia de hoy", "Error", MessageBoxButtons.OK);
                    Close();
                }
                else
                {
                    using (var reader = new DotNetDBF.DBFReader(originalFilePathConTarjeta))
                    {
                        using (var writer = new DotNetDBF.DBFWriter(newFilePath))
                        {
                            writer.Fields = reader.Fields;

                            int currentIndex = 0;
                            object[] record;
                            while ((record = reader.NextRecord()) != null)
                            {
                                if (currentIndex == registroSustituir)
                                {

                                    record[8] = txtHoraSalida.Text; 
                                }

                                writer.WriteRecord(record);

                                currentIndex++;
                            }
                        }
                    }
                    File.Delete(originalFilePathConTarjeta);
                    File.Move(newFilePath, originalFilePathConTarjeta);
                    MessageBox.Show("Registro actualizado");
                }

                this.Close();
            }
            else
            {
                registroSustituir = ABM.GetindiceRegistro(originalFilePathSinTarjeta, nudLegajo.Value.ToString(), 0);

                if (registroSustituir == -1 || fechaActual != txtFecha.Text)
                {
                    MessageBox.Show("La fecha del registro no es la misma del dia de hoy", "Error", MessageBoxButtons.OK);
                    Close();
                }
                else
                {
                    using (var reader = new DotNetDBF.DBFReader(originalFilePathSinTarjeta))
                    {
                        using (var writer = new DotNetDBF.DBFWriter(newFilePath))
                        {
                            writer.Fields = reader.Fields;

                            int currentIndex = 0;
                            object[] record;
                            while ((record = reader.NextRecord()) != null)
                            {
                                if (currentIndex == registroSustituir)
                                {

                                    record[8] = txtHoraSalida.Text; 
                                }

                                writer.WriteRecord(record);

                                currentIndex++;
                            }
                        }
                    }
                    File.Delete(originalFilePathSinTarjeta);
                    File.Move(newFilePath, originalFilePathSinTarjeta);
                    MessageBox.Show("Registro actualizado");
                }
            }
        }
    }
}

