using CapaDatos;
using CapaSesion;
using CapaServicios;

namespace CapaNegocio
{
    public class CN_ValidarUsuario
    {
        private readonly string nombreusuario;
        private readonly string Username;
        private readonly string Password;
        private readonly int digito;

        ComparaDigitoVerificador comparador;
        CD_ValidarUsuario validarusuario;

        public CN_ValidarUsuario()
        {
        }

        public CN_ValidarUsuario(string username, string pass)
        {
            Username = username;
            Password = pass;
            comparador = new ComparaDigitoVerificador();
            validarusuario = new CD_ValidarUsuario();
            digito = Seguridad.hasheo(Username, Password);
        }


        public bool ValidarNombreUsuarioL()
        {
            
            bool existe = validarusuario.ValidarNombreUsuarioD(Username);
            if (existe && comparador.ComparaDigito(digito, Username) == true && comparadorPass.ComparaPass(Username, Password) && )
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

            bool existe = validarusuario.ValidarNombreUsuarioD(usuario);
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
