using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaSesion
{
    public class Familia
    {

        public int IdFamilia { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public List<FamiliaPermiso> Permisos { get; set; }
    }
}
