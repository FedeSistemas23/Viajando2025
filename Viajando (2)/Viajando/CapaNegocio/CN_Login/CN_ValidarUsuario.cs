using CapaDatos;
using CapaServicios;
using CapaSesion;

namespace CapaNegocio
{
    public class CN_ValidarUsuario
    {
        

        CD_ValidarUsuario obj= new CD_ValidarUsuario();


        public bool Login(Usuario usuario, out string mensaje)
        {
            mensaje = string.Empty;
            string passwordHash = usuario.Username + usuario.Password; 
            
            usuario.Password = Seguridad.SHA256(passwordHash);
            usuario.DigitoVerificador = Seguridad.Hasheo(usuario.Username, usuario.Password);

            return obj.Login(usuario, out mensaje);
        }        
    }
}
