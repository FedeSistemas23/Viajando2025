using CapaDatos;
using CapaSesion;

namespace CapaNegocio
{
    public class CN_AltaUsuario
    {
        CD_AltaUsuario usuarioD = new CD_AltaUsuario();
        
        public int AltaUsuario(Usuario usuario, out string mensaje)
        {
            usuarioD.GuardarUsuarioD(usuario);
        }
    }
}


