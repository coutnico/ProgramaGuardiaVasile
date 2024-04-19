using CapturarIngresos.Models;
using DotNetDBF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapturarIngresos
{
    public partial class PaginaPrincipal : Form
    {
        private System.Windows.Forms.Timer timer;
        public Login login = new Login();
        private DBFWriter writer;
        string rutaBase = "R:\\sistemas_nico\\CapturarIngresosVMate\\database\\";

        private bool panelExpandido = true;
        private bool MenuExpandido1;
        private bool MenuExpandido2;
        private bool MenuExpandido3;
        const int animationStep = 10;


        public event EventHandler DatosActualizados;


        public PaginaPrincipal()
        {
            InitializeComponent();
            InitializeTimer();


        }
        private void PaginaPrincipal_Load(object sender, EventArgs e)
        {
            KeyboardListener.EightDigitsKeyPressed += KeyboardListener_EightDigitsKeyPressed;

        }

        private void KeyboardListener_EightDigitsKeyPressed(object sender, EightDigitsEventArgs e)
        {
            int numerocapturado = Convert.ToInt32(string.Join("", e.Digits));

            
            var resultado = BuscarEmpleado(numerocapturado);
            Empleado ingresoempleado = (Empleado)resultado.empleado;
            bool EstaDadoDeBaja = (bool)resultado.baja;

            if (ingresoempleado.Legajo != 0)
            {
                if (!EstaDadoDeBaja)
                {
                    AgregarIngresoEmpleado(ingresoempleado);
                    OnDatosActualizados();
                }

            }
        }


        private void InitializeTimer()
        {
            // Crea un nuevo temporizador
            timer = new System.Windows.Forms.Timer();

            // Establece el intervalo del temporizador en 1 segundo (1000 milisegundos)
            timer.Interval = 1000;

            // Asocia el evento Tick con el método Tick del temporizador
            timer.Tick += Timer_Tick;

            // Inicia el temporizador
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Actualiza el texto del Label con la hora actual
            labelHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblFecha.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");

        }

        private void ibSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OpenChildForm(Form childForm)
        {

            // Si hay un formulario secundario abierto, ciérralo antes de abrir uno nuevo
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

            // Establece el formulario secundario pasado como argumento como formulario hijo del formulario principal
            childForm.MdiParent = this;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            childForm.FormBorderStyle = FormBorderStyle.None;
            panelPadre.Visible = false;
            childForm.Show();

            childForm.FormClosed += (sender, e) =>
            {

                panelPadre.Visible = true;
            };


            childForm.Show();
        }

        private void ibAgregar_Click(object sender, EventArgs e)
        {
            FormularioIngreso formularioIngreso = new FormularioIngreso();
            OpenChildForm(formularioIngreso);


        }

        private void ibModificar_Click(object sender, EventArgs e)
        {
            BMIngresos modificarRegistros = new BMIngresos("Modificar");
            OpenChildForm(modificarRegistros);


        }

        private void ibGuardados_Click(object sender, EventArgs e)
        {
            if (!PanelHistoricoIngresos.Visible)
            {
                PanelHistoricoIngresos.Visible = true;

                panelOpcionesIngreso.Size = new System.Drawing.Size(203, 254);
            }
            else
            {
                PanelHistoricoIngresos.Visible = false;

                panelOpcionesIngreso.Size = new System.Drawing.Size(203, 168);

            }


        }
        private void ibEmpleadosHistoricos_Click(object sender, EventArgs e)
        {
            RegistrosGuardados registrosGuardados = new RegistrosGuardados("IngresosEmpleados", this);
            OpenChildForm(registrosGuardados);
        }
        private void ibVisitantesHistoricos_Click(object sender, EventArgs e)
        {
            RegistrosGuardados registrosGuardados = new RegistrosGuardados("IngresosVisitante");
            OpenChildForm(registrosGuardados);
        }

        private void ibHome_Click(object sender, EventArgs e)
        {
            panelPadre.Visible = true;
        }

        private void ibEliminar_Click(object sender, EventArgs e)
        {
            BMIngresos modificarRegistros = new BMIngresos("Eliminar");
            OpenChildForm(modificarRegistros);

        }

        private void ibIngresos_Click(object sender, EventArgs e)
        {
            timerPanelIngresos.Start();

            /*
            if (panelOpcionesIngreso.Visible)
            {
                panelOpcionesIngreso.Visible = false;
            }
            else
            {
                panelOpcionesIngreso.Visible = true;
            }
            */

        }


        private void ibTransportista_Click(object sender, EventArgs e)
        {
            timerPanelChoferes.Start();
        }

        private void ibNuevotrans_Click(object sender, EventArgs e)
        {
            AgregarTransportista agregartrans = new AgregarTransportista();
            OpenChildForm(agregartrans);

        }

        private void ibModificartrans_Click(object sender, EventArgs e)
        {
            BMTransportista modtrans = new BMTransportista("Modificar");
            OpenChildForm(modtrans);
        }

        private void ibEliminartrans_Click(object sender, EventArgs e)
        {
            BMTransportista elimtrans = new BMTransportista("Eliminar");
            OpenChildForm(elimtrans);
        }

        private void ibHistoricosTrans_Click(object sender, EventArgs e)
        {
            RegistrosGuardados registrosTrans = new RegistrosGuardados("Choferes");
            OpenChildForm(registrosTrans);

        }


        private void ibDesplegable_Click(object sender, EventArgs e)
        {
            if (!panelMenuUsuario.Visible)
            {
                panelMenuUsuario.Visible = true;
                ibDesplegable.IconChar = FontAwesome.Sharp.IconChar.ChevronUp;
            }
            else
            {
                panelMenuUsuario.Visible = false;
                ibDesplegable.IconChar = FontAwesome.Sharp.IconChar.ChevronDown;

            }
        }

        private void ibGestorTrans_Click(object sender, EventArgs e)
        {
            timerPanelTransporte.Start();
        }

        private void ibHistoricoEntradaySalida_Click(object sender, EventArgs e)
        {
            if (!panelOpcionesHistorico.Visible)
            {
                panelOpcionesHistorico.Visible = true;
            }
            else
            {
                panelOpcionesHistorico.Visible = false;
            }
        }

        private void ibEntrada_Click(object sender, EventArgs e)
        {
            GestorEySTransporte entrada = new GestorEySTransporte("Entrada");
            OpenChildForm(entrada);
        }

        private void ibSalida_Click(object sender, EventArgs e)
        {
            GestorEySTransporte entrada = new GestorEySTransporte("Salida");
            OpenChildForm(entrada);
        }

        private void ibHistoricoEntrada_Click(object sender, EventArgs e)
        {
            RegistrosGuardados registrosentrada = new RegistrosGuardados("TransportesEntrada");
            OpenChildForm(registrosentrada);
        }

        private void ibHistoricoSalida_Click(object sender, EventArgs e)
        {
            RegistrosGuardados registrossalida = new RegistrosGuardados("TransportesSalida");
            OpenChildForm(registrossalida);
        }

        private void ibIniciarSesion_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            /*
            if (login.ShowDialog() == DialogResult.OK)
            {
                lblUsuario.Text = UsuarioActual.NombreUsuario;
                if (UsuarioActual.Permiso == 1)
                {
                    panelOpcionesGestor.Visible = true;
                    panelOpcionesGestor.Visible = false;
                    ibGestorTrans.Visible = true;
                    panelOpcionstrans.Visible = true;
                    panelOpcionstrans.Visible = false;
                    ibChoferes.Visible = true;
                    panelOpcionesIngreso.Visible = true;
                    panelOpcionesIngreso.Visible = false;
                    ibIngresos.Visible = true;
                    lblUsuario.Location = new Point(633, 31);

                }
                else
                {
                    panelOpcionesGestor.Visible = true;
                    panelOpcionesGestor.Visible = false;
                    ibGestorTrans.Visible = true;           
                    panelOpcionstrans.Visible = false;
                    ibChoferes.Visible = false;
                    panelOpcionesIngreso.Visible = true;
                    panelOpcionesIngreso.Visible = false;
                    ibIngresos.Visible = true;
                    lblUsuario.Location = new Point(710, 31);
                }

            }
            */
        }


        private void ibCerrarSesion_Click(object sender, EventArgs e)
        {
            lblUsuario.Text = string.Empty;
            panelOpcionesGestor.Visible = false;
            ibGestorTrans.Visible = false;
            panelOpcionstrans.Visible = false;
            ibChoferes.Visible = false;
            panelOpcionesIngreso.Visible = false;
            ibIngresos.Visible = false;

            MessageBox.Show("Sesion cerrada exitosamente", "Aviso", MessageBoxButtons.OK);
        }

        private void PaginaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            KeyboardListener.StopListening();
        }


        private (Empleado empleado, bool baja) BuscarEmpleado(int nroTarjeta)
        {
            Empleado empleado = new Empleado();
            bool Baja = false;
            DataTable datatable = new DataTable();
            DatabaseLoader loader = new DatabaseLoader();
            datatable = loader.LoadData("Empleados");


            DataRow[] rows = datatable.Select("XTARP = '" + nroTarjeta + "'");

            if (rows.Length > 0)
            {
                // Obtener los valores del registro encontrado
                empleado.NumeroDeTarjeta = Convert.ToInt32(rows[0]["XTARP"]);
                empleado.Legajo = Convert.ToInt32(rows[0]["XLEG"]);
                empleado.Apellido = rows[0]["XAPE"].ToString();
                empleado.Nombre = rows[0]["XNOM"].ToString();
                empleado.DNI = rows[0]["XDOC"].ToString();
                empleado.Sector = rows[0]["XSEC"].ToString();

                if (string.IsNullOrEmpty(rows[0]["XBAJA"].ToString()))
                {
                    Baja = false;
                }
                else
                {
                    Baja = true;
                }

            }


            return (empleado, Baja);

        }
        private void AgregarIngresoEmpleado(Empleado e)
        {


            if (!File.Exists(rutaBase + "IngresosEmpleados.dbf"))
            {
                writer = new DBFWriter(rutaBase + "IngresosEmpleados.dbf");


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
                            new DBFField("HoraSali", NativeDbType.Char, 20)

                };
                writer.Fields = fields;
            }
            else
            {
                writer = new DBFWriter(rutaBase + "IngresosEmpleados.dbf");

            }

            writer.WriteRecord(e.Legajo, e.Apellido, e.Nombre, e.DNI, e.NumeroDeTarjeta, e.Sector, ABM.getFechaActual(), ABM.getHoraActual(), "");
            writer.Close();


        }
        private void OnDatosActualizados()
        {
            DatosActualizados?.Invoke(this, EventArgs.Empty);
        }

        private void cbRecibirIngresos_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRecibirIngresos.Checked)
            {
                KeyboardListener.StartListening();
            }
            else
            {
                KeyboardListener.StopListening();
            }
        }

        private void timerPanelExpandible_Tick(object sender, EventArgs e)
        {
            if (panelExpandido)
            {
                if (MenuExpandido1 == true)
                {

                    panelIngresos.Height = 60;
                    MenuExpandido1 = false;

                }
                if (MenuExpandido2 == true)
                {

                    panelChoferes.Height = 60;
                    MenuExpandido2 = false;

                }
                if (MenuExpandido3 == true)
                {

                    panelTransporte.Height = 60;
                    MenuExpandido3 = false;

                }

                panelMenu.Width -= 10;
                pictureBox1.Location = new Point(pictureBox1.Location.X - 1, pictureBox1.Location.Y);


                if (panelMenu.Width <= panelMenu.MinimumSize.Width)
                {
                    timerPanelExpandible.Stop();
                    panelExpandido = false;
                }
            }
            else
            {
                panelMenu.Width += 10;
                pictureBox1.Location = new Point(pictureBox1.Location.X + 1, pictureBox1.Location.Y);

                if (panelMenu.Width >= 220)
                {
                    timerPanelExpandible.Stop();
                    panelExpandido = true;
                }
            }
        }


        private void ibDesplegarMenu_Click(object sender, EventArgs e)
        {
            timerPanelExpandible.Start();
        }

        private void timerPanelIngresos_Tick(object sender, EventArgs e)
        {

            if (panelMenu.Width != panelMenu.MinimumSize.Width)
            {

                if (MenuExpandido1)
                {
                    if (panelIngresos.Height > 60) // Ajusta este valor según la altura mínima deseada
                    {
                        panelIngresos.Height = Math.Max(60, panelIngresos.Height - animationStep);
                    }
                    else
                    {
                        timerPanelIngresos.Stop();
                        MenuExpandido1 = false;
                    }
                }
                else
                {
                    if (panelIngresos.Height < 328) // Ajusta este valor según la altura máxima deseada
                    {
                        panelIngresos.Height = Math.Min(328, panelIngresos.Height + animationStep);
                    }
                    else
                    {
                        timerPanelIngresos.Stop();
                        MenuExpandido1 = true;
                    }
                }
            }
        }

        private void timerPanelChoferes_Tick(object sender, EventArgs e)
        {
            if (panelMenu.Width != panelMenu.MinimumSize.Width)
            {

                if (MenuExpandido2)
                {
                    if (panelChoferes.Height > 60) // Ajusta este valor según la altura mínima deseada
                    {
                        panelChoferes.Height = Math.Max(60, panelChoferes.Height - animationStep);
                    }
                    else
                    {
                        timerPanelChoferes.Stop();
                        MenuExpandido2 = false;
                    }
                }
                else
                {
                    if (panelChoferes.Height < 116) // Ajusta este valor según la altura máxima deseada
                    {
                        panelChoferes.Height = Math.Min(116, panelChoferes.Height + animationStep);
                    }
                    else
                    {
                        timerPanelChoferes.Stop();
                        MenuExpandido2 = true;
                    }
                }
            }
        }

        private void timerPanelTransporte_Tick(object sender, EventArgs e)
        {
            if (panelMenu.Width != panelMenu.MinimumSize.Width)
            {

                if (MenuExpandido3)
                {
                    if (panelTransporte.Height > 60) // Ajusta este valor según la altura mínima deseada
                    {
                        panelTransporte.Height = Math.Max(60, panelTransporte.Height - animationStep);
                    }
                    else
                    {
                        timerPanelTransporte.Stop();
                        MenuExpandido3 = false;
                    }
                }
                else
                {
                    if (panelTransporte.Height < 288) // Ajusta este valor según la altura máxima deseada
                    {
                        panelTransporte.Height = Math.Min(288, panelTransporte.Height + animationStep);
                    }
                    else
                    {
                        timerPanelTransporte.Stop();
                        MenuExpandido3 = true;
                    }
                }
            }
        }

        private void panelPadre_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ibInformes_Click(object sender, EventArgs e)
        {
            viewInformes informe = new viewInformes();
            informe.ShowDialog();
        }
    }
}
