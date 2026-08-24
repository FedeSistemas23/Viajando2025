using CapaDatos;
using CapaServicios;
using CapaSesion;

namespace CapaNegocio
{
    public class CN_AltaUsuario
    {
        CD_AltaUsuario usuarioD = new CD_AltaUsuario();
        
        public bool AltaUsuario(Usuario usuario, out string mensaje)
        {  
            mensaje = string.Empty;
            
            string aleatorio = Aleatorios.Armar();
            usuario.Password = aleatorio;

            string passwordHash = usuario.Username + usuario.Password;

            usuario.Password = Seguridad.SHA256(passwordHash);
            usuario.DigitoVerificador = Seguridad.Hasheo(usuario.Username, usuario.Password);
            
            if (usuarioD.GuardarUsuarioD(usuario, out mensaje))
            {
                return true;
            }
            else
            {
                mensaje = "Error al guardar el usuario.";
                return false;
            }    
        }
    }
}


