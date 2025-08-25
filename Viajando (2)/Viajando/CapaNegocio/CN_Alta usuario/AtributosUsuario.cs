using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{

    // Esta clase se llama al momento de dar de alta a un usuario en el sistema  
    public class CN_NuevoUsuario

    {
        public string Username { get; set; }
        public string Nombre { get; set; }
        public string password { get; set; }
        public string Email { get; set; }

        public string Apellidos { get; set; }

        public string TipoDocumento { get; set; }
        public string NumDocumento { get; set; }

        public string Telefono { get; set; }
        public string Celular { get; set; }

        public string Calle { get; set; }
        public string NumCalle { get; set; }
        public int Digito { get; set; }

        public string Localidad { get; set; }

        List<CN_NuevoUsuario> cN_NuevoUsuarios { get; set; }


        public int familia { get; set; }

        public int intentos { get; set; }
        public int venceCada { get; set; }
        public bool Bloqueado { get; set; }

    } 

    
}
