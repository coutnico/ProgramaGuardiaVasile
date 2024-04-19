using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapturarIngresos.Models
{
    public static class UsuarioActual
    {
        public static string NombreUsuario { get; set; }
        public static string Contraseña { get; set; }
        public static int  Permiso { get; set; }
    }
}
