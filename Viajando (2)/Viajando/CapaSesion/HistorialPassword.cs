using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaSesion
{
    public class HistorialPassword
    {
        public int IdHistorial { get; set; }

        public int IdUsuario { get; set; }

        public string PasswordHash { get; set; }

        public DateTime FechaCambio { get; set; }
    }
}
