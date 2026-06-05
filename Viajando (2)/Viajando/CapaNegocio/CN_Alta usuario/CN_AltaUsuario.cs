using CapaDatos;
using CapaSesion;

namespace CapaNegocio
{
    public class CN_AltaUsuario
    {
        CD_AltaUsuario usuarioD = new CD_AltaUsuario();
        
        public void AñadirAtributos(Usuario usuario)
        {
            usuarioD.GuardarUsuarioD(usuario);
        }
    }
}


