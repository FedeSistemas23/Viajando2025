using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaSesion
{
    public class UsuarioPermiso
    {
                
            public int IdUsuario { get; set; }

            public int IdPermiso { get; set; }

            public DateTime? FechaCaducidad { get; set; }

            public Usuario Usuario { get; set; }

            public Permiso Permiso { get; set; }
        
    }
}
