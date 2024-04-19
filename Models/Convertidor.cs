using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapturarIngresos.Models
{
    public static class Convertidor
    {

        public static string ImageToBase64(string imagePath)
        {

            try
            {
                // Leer la imagen desde el archivo
                byte[] imageBytes = File.ReadAllBytes(imagePath);

                // Convertir la imagen en una cadena Base64
                string base64String = Convert.ToBase64String(imageBytes);

                return base64String;
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante la conversión
                System.Windows.Forms.MessageBox.Show($"{ex.Message}");
                return null;
            }
        }

        public static Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            using (MemoryStream memoryStream = new MemoryStream(imageBytes))
            {
                // Convertir los bytes de la imagen en un objeto Image
                Image image = Image.FromStream(memoryStream);
                return image;
            }
        }
    }
}
