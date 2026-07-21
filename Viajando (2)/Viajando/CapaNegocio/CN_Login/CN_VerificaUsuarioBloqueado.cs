using CapaSesion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_VerificaUsuarioBloqueado
    {
        public CN_VerificaUsuarioBloqueado() { }

        public bool VerificarUsuarioBloqueado()
        {
            if (CS_UsuarioEnSesion.Bloqueado == true)
            {
                return true;
            }
            else
            {
                return false;
            }
         
        }
    }
}
