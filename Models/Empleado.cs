using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapturarIngresos.Models
{
    public class Empleado
    {
        public int Legajo { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string DNI { get; set; }
        public int NumeroDeTarjeta { get; set; }
        public string Sector { get; set; }

    }
}
