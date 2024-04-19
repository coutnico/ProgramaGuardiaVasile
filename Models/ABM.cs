using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapturarIngresos.Models
{
    public static class ABM
    {
        static string fechaActual = DateTime.Today.ToString("dd/MM/yyyy");
        static string horaactual;

        static string nuevoFilePath = "R:\\sistemas_nico\\CapturarIngresosVMate\\database\\";


        public static int GetindiceRegistro(string originalFilePath, string filtro, int indexcampo)
        {
            int indice = 0;
            int indiceregistro = 0;
            bool bandera = false;


            using (var reader = new DotNetDBF.DBFReader(originalFilePath))
            {
                object[] record;
                while ((record = reader.NextRecord()) != null)
                {
                    string valorCampo = record[indexcampo]?.ToString();

                    if (valorCampo == filtro)
                    {
                        indiceregistro = indice;
                        bandera = true;
                        break;

                    }
                    indice++;
                }
                if (bandera)
                {
                    return indiceregistro;
                }
                else
                {
                    return -1;
                }
            }
        }
        public static int GetindiceRegistro(string originalFilePath, string filtro, int indexcampo1, int indexcampo2)
        {
            int indice = 0;
            int indiceregistro = 0;
            bool bandera = false;


            using (var reader = new DotNetDBF.DBFReader(originalFilePath))
            {
                object[] record;
                while ((record = reader.NextRecord()) != null)
                {
                    string valorCampo = record[indexcampo1]?.ToString();
                    string valorFecha = record[indexcampo2]?.ToString();

                    if (valorCampo == filtro && valorFecha == getFechaActual())
                    {
                        indiceregistro = indice;
                        bandera = true;
                        break;

                    }
                    indice++;
                }
                if (bandera)
                {
                    return indiceregistro;
                }
                else
                {
                    return -1;
                }
            }
        }
        public static string getFechaActual()
        {
            return fechaActual;
        }
        public static string getHoraActual()
        {
            horaactual = DateTime.Now.ToString("HH:mm");
            return horaactual;
        }

        public static void EliminarRegistroPorIndice(string originalFilePath, int indiceRegistro)
        {
            // Verificar que el índice del registro sea válido
            if (indiceRegistro < 0)
            {
                MessageBox.Show("El índice del registro es inválido", "Error", MessageBoxButtons.OK);
                return;
            }

            try
            {
                nuevoFilePath += "tempelim.dbf";

                using (var reader = new DotNetDBF.DBFReader(originalFilePath))
                {
                    // Crea un nuevo archivo DBF
                    using (var writer = new DotNetDBF.DBFWriter(nuevoFilePath))
                    {
                        // Copia el encabezado del archivo original al nuevo archivo
                        writer.Fields = reader.Fields;

                        // Lee y escribe todos los registros, sustituyendo el registro específico cuando se encuentra
                        int currentIndex = 0;
                        object[] record;
                        while ((record = reader.NextRecord()) != null)
                        {
                            if (currentIndex != indiceRegistro)
                            {
                                writer.WriteRecord(record);

                            }


                            currentIndex++;
                        }
                    }
                }
                File.Delete(originalFilePath);
                File.Move(nuevoFilePath, originalFilePath);
                MessageBox.Show("Registro Eliminado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar eliminar el registro: " + ex.Message, "Error", MessageBoxButtons.OK);
            }
        }
    }
}
