using CapaDatos;
using CapaSesion;

namespace CapaNegocio
{
    public class CN_Alta_Usuario
    {
        CD_AltaUsuario usuarioD = new CD_AltaUsuario();
        
        public void AñadirAtributos(CN_Nuevo_Usuario usuario)
        {
            usuarioD.GuardarUsuarioD(usuario);
        }
    }
}


