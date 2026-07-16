using CapaDatos;
using CapaServicios;
using CapaSesion;

namespace CapaNegocio
{
    public class CN_ValidarUsuario
    {
        private string nombreusuario;
        string Username;
        private string Password;

        CD_ValidarUsuario validador;
       

        public bool Login(Usuario usuario, out string mensaje)
        {
            mensaje = string.Empty;
            bool existe = validador.ValidarNombreUsuarioD(usuario, mensaje);

            if ()
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //el sigueinte metodo validar usuario se utiliza para verificar si el usuario existe, cuando ingresa el usuario desde 
        //el formulario de preguntas de seguridad, cuando olvida su contraseña.
        public bool ValidarNombreUsuarioL(string usuario)
        {


            bool existe = validador.ValidarNombreUsuarioD(usuario);

            if (existe)
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
