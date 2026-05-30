using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaSesion
{
    public class FamiliaPermiso
    {
        public int IdUsuario { get; set; }

        public int IdPermiso { get; set; }

        public DateTime? FechaCaducidad { get; set; }

        public Permiso Permiso { get; set; }

    }
}
