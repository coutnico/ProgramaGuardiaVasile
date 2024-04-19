using CapturarIngresos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CapturarIngresos
{
    public partial class BMTransportista : Form
    {
        static string connectionString = "server=192.168.1.180; database=AppIngresos; user=sa; password=Vasile123";
        SqlConnection conexion = new SqlConnection(connectionString);
        DatabaseLoader loader = new DatabaseLoader();

        string originalFilePath = "Z:\\CARLOS SISTEMA\\sistemas_nico\\CapturarIngresosVMate\\database\\Choferes.dbf";
        string newFilePath = "Z:\\CARLOS SISTEMA\\sistemas_nico\\CapturarIngresosVMate\\database\\temp2.dbf";

        string rutaImages = "Z:\\CARLOS SISTEMA\\sistemas_nico\\CapturarIngresosVMate\\ImagenesCapturadas\\Choferes";


        public BMTransportista(string modo)
        {
            InitializeComponent();


            if (modo == "Modificar")
            {
                lblIngreso.Text = "Modificar Chofer";
                ibEliminar.Visible = false;
                ibModificar.TabIndex = 7;
            }
            else
            {
                lblIngreso.Text = "Eliminar Chofer";
                ibModificar.Visible = false;
                ibEliminar.TabIndex = 7;

            }
        }
        private DataRow[] BuscarPorRegistro(DataTable dataTable, int legajo)
        {
            // Filtrar las filas según el DNI
            DataRow[] resultados = dataTable.Select($"Legajo = {legajo}");
            return resultados;
        }

        private void ibBuscar_Click(object sender, EventArgs e)
        {
            int LegajoABuscar = (int)nudNroTarjeta.Value;

            int indexRegistromodificar = ABM.GetindiceRegistro(originalFilePath, LegajoABuscar.ToString(), 2);
            using (var reader = new DotNetDBF.DBFReader(originalFilePath))
            {
                int currentIndex = 0;
                object[] record;
                while ((record = reader.NextRecord()) != null)
                {
                    if (currentIndex == indexRegistromodificar)
                    {
                        nudLegajo.Value = Convert.ToInt32(record[0]);
                        txtNombre.Text = record[1].ToString();
                        nudNroTarjeta.Value = Convert.ToInt32(record[2]);
                        nudRegistro.Value = Convert.ToInt32(record[3]);
                        txtDNI.Text = record[4].ToString();
                        txtFecha.Text = record[5].ToString();

                        string[] archivosImagen = Directory.GetFiles(rutaImages, nudLegajo.Value.ToString() + ".*");

                        pictureBox1.Image = Image.FromFile(archivosImagen[0]);
                    }



                    currentIndex++;
                }
            }

        }

        private void ibModificar_Click(object sender, EventArgs e)
        {
            int registroSustituir = ABM.GetindiceRegistro(originalFilePath, nudLegajo.Value.ToString(), 0);

            if (registroSustituir == -1)
            {        
                Close();
            }
            else
            {
                using (var reader = new DotNetDBF.DBFReader(originalFilePath))
                {
                    // Crea un nuevo archivo DBF
                    using (var writer = new DotNetDBF.DBFWriter(newFilePath))
                    {
                        // Copia el encabezado del archivo original al nuevo archivo
                        writer.Fields = reader.Fields;

                        // Lee y escribe todos los registros, sustituyendo el registro específico cuando se encuentra
                        int currentIndex = 0;
                        object[] record;
                        while ((record = reader.NextRecord()) != null)
                        {
                            if (currentIndex == registroSustituir)
                            {
                                record[0] = Convert.ToInt32(nudLegajo.Value);
                                record[1] = txtNombre.Text;
                                record[2] = Convert.ToInt32(nudNroTarjeta.Value);      
                                record[3] = Convert.ToInt32(nudRegistro.Value);      
                                record[4] = txtDNI.Text;
                                record[5] = txtFecha.Text;
                            }

                            // Escribe el registro en el nuevo archivo
                            writer.WriteRecord(record);

                            currentIndex++;
                        }
                    }
                }
                File.Delete(originalFilePath);
                File.Move(newFilePath, originalFilePath);
                MessageBox.Show("Registro actualizado");
            }
        }

        private void ibEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int indiceRegistroAEliminar = ABM.GetindiceRegistro(originalFilePath, nudLegajo.Value.ToString(), 0);

                ABM.EliminarRegistroPorIndice(originalFilePath, indiceRegistroAEliminar);


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");

            }
            finally
            {
                conexion.Close();

            }
        }

        private void BMTransportista_Load(object sender, EventArgs e)
        {
            nudNroTarjeta.Focus();
            nudNroTarjeta.Select(0, nudNroTarjeta.Value.ToString().Length);
        }
    }
}
