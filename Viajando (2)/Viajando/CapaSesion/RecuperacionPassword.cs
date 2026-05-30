using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaSesion
{
    public class RecuperacionPassword
    {
        public int IdRecuperacion { get; set; }

        public int IdUsuario { get; set; }

        public DateTime FechaSolicitud { get; set; }

        public string PasswordTemporalHash { get; set; }

        public bool Utilizada { get; set; }

    }
}
