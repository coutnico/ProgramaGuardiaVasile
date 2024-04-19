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
using System.IO;
using System.Diagnostics.Eventing.Reader;
using DotNetDBF;

namespace CapturarIngresos
{
    public partial class BMIngresos : Form
    {
        Ingresante ingresofiltrado = new Ingresante();
        DatabaseLoader loader = new DatabaseLoader();

        string originalFilePathVisitante = "R:\\sistemas_nico\\CapturarIngresosVMate\\database\\IngresosVisitante.dbf";
        string newFilePathVisitante = "R:\\sistemas_nico\\CapturarIngresosVMate\\database\\temp5.dbf";

        string carpetaImagenes = "R:\\sistemas_nico\\CapturarIngresosVMate\\ImagenesCapturadas\\Visitantes\\";

        public BMIngresos(string modo)
        {
            InitializeComponent();

            if (modo == "Modificar")
            {
                ibEliminar.Visible = false;
                ibModificar.Visible = true;
                lblIngreso.Text = "Modificar Ingreso";
            }
            else
            {
                ibEliminar.Visible = true;
                ibModificar.Visible = false;
                lblIngreso.Text = "Eliminar Ingreso";
                tbxNombres.ReadOnly = true;
                tbxApellido.ReadOnly = true;

            }
        }
        private void BMIngresos_Load(object sender, EventArgs e)
        {
            //Tipos
            cbTipo.Items.Add("INSPECCION");
            cbTipo.Items.Add("PROVEEDORES");
            cbTipo.Items.Add("CLIENTES");
            cbTipo.Items.Add("ENTREVISTA");
            //Sector
            cbSectorVisitante.Items.Add("PLANTA");
            cbSectorVisitante.Items.Add("ADMINISTRACION");
        }

        [Obsolete]
        private void ibBuscar_Click(object sender, EventArgs e)
        {
            int dniOLegajoABuscar = (int)nudDni.Value;
            int indexRegistromodificar = 0;


            indexRegistromodificar = ABM.GetindiceRegistro(originalFilePathVisitante, nudDni.Value.ToString(), 0);
            using (var reader = new DotNetDBF.DBFReader(originalFilePathVisitante))
            {
                int currentIndex = 0;
                object[] record;
                while ((record = reader.NextRecord()) != null)
                {
                    if (currentIndex == indexRegistromodificar)
                    {
                        txtDNI.Text = record[0].ToString();
                        tbxApellido.Text = record[1].ToString();
                        tbxNombres.Text = record[2].ToString();
                        cbTipo.SelectedItem = record[3].ToString();
                        cbSectorVisitante.SelectedItem = record[4].ToString();
                        cbArea.SelectedItem = record[5].ToString();
                        cbSubArea.SelectedItem = record[6].ToString();
                        txtHora.Text = record[7].ToString();
                        txtFecha.Text = record[8].ToString();

                        string[] archivosImagen = Directory.GetFiles(carpetaImagenes, txtDNI.Text + ".jpg");

                        pictureBox1.Image = Image.FromFile(archivosImagen[0]);
                    }



                    currentIndex++;
                }
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
            else if (cbArea.SelectedItem.ToString() == "DISTRIBUCION")
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

        private void cbSubArea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void ibModificar_Click(object sender, EventArgs e)
        {
            int registroSustituir = 0;


            registroSustituir = ABM.GetindiceRegistro(originalFilePathVisitante, txtDNI.Text, 0);

            if (registroSustituir == -1 || ABM.getFechaActual() != txtFecha.Text)
            {
                MessageBox.Show("La fecha del registro no es la misma del dia de hoy", "Error", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                using (var reader = new DotNetDBF.DBFReader(originalFilePathVisitante))
                {
                    // Crea un nuevo archivo DBF
                    using (var writer = new DotNetDBF.DBFWriter(newFilePathVisitante))
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
                                record[0] = txtDNI.Text;
                                record[1] = tbxApellido.Text;
                                record[2] = tbxNombres.Text;
                                record[3] = cbTipo.SelectedItem;
                                record[4] = cbSectorVisitante.SelectedItem;
                                record[5] = cbArea.SelectedItem;
                                record[6] = cbSubArea.SelectedItem;
                                record[7] = txtHora.Text;
                                record[8] = txtFecha.Text;
                            }

                            // Escribe el registro en el nuevo archivo
                            writer.WriteRecord(record);

                            currentIndex++;
                        }
                    }
                }
                File.Delete(originalFilePathVisitante);
                File.Move(newFilePathVisitante, originalFilePathVisitante);
                MessageBox.Show("Registro actualizado");
            }
        }




        private void ibEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int indiceRegistroAEliminar = ABM.GetindiceRegistro(originalFilePathVisitante, nudDni.Value.ToString(), 0);


                ABM.EliminarRegistroPorIndice(originalFilePathVisitante, indiceRegistroAEliminar);


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");

            }

        }

        private void cbSectorVisitante_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbArea.Items.Clear();

            if (cbSectorVisitante.SelectedItem.ToString() == "ADMINISTRACION")
            {
                cbSubArea.Items.Clear();


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
                //Area
                cbArea.Items.Add("DISTRIBUCION");
                cbArea.Items.Add("POTENCIA");
            }
        }


    }
}
