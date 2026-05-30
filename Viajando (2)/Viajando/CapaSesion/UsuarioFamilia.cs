using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaSesion
{
    public class UsuarioFamilia
    {
        public int IdUsuario { get; set; }

        public int IdFamilia { get; set; }

        public Familia Familia { get; set; }

    }
}
