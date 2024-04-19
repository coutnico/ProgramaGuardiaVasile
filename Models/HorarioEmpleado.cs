using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapturarIngresos.Models
{
    public class HorarioEmpleado
    {
        public int legajo { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string HoraIngreso { get; set; }
        public string HoraSalida { get; set; }




        public void SetStringtoDate(string fecha)
        {
            string[] formatosPosibles = { "d/M/yyyy", "dd/M/yyyy", "d/MM/yyyy", "dd/MM/yyyy" };

            DateTime FechaDate;
            if (DateTime.TryParseExact(fecha, formatosPosibles, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out FechaDate))
            {
                string fechaFormateada = FechaDate.ToString("dd/MM/yyyy");

                FechaModificacion = DateTime.Parse(fechaFormateada);
            }
            else
            {
                Console.WriteLine("La cadena no tiene ninguno de los formatos posibles");
            }
        }

    }


}
