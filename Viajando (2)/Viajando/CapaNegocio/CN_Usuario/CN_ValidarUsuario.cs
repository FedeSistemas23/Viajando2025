using CapaDatos;
<<<<<<< HEAD
using CapaNegocio.CN_Usuario;
=======
using CapaSesion;
>>>>>>> castel
using CapaServicios;

namespace CapaNegocio
{
    public class CN_ValidarUsuario
    {
        private string nombreusuario;
        string Username;
        private string Password;
<<<<<<< HEAD
        CD_ValidarUsuario validador;
        CN_ComparaDigitoVerificador comparador;
        CN_ComparaPassword comparaPass;

        public CN_ValidarUsuario()
        {
            comparador = new CN_ComparaDigitoVerificador();
            validador = new CD_ValidarUsuario();
            comparaPass = new CN_ComparaPassword();
        }

        public bool ValidarUsuarioL(string usuario, string pass)
        {
            bool existe = validador.ValidarNombreUsuarioD(usuario);

            if (existe && comparador.ComparaDigitoVerificador(pass, usuario)
                && comparaPass.ComparaPassword(pass, usuario)) 
                //&& verificadorBloqueo.VerificarUsuarioBloqueado()
=======
        CD_ValidarUsuario validarusuario = new CD_ValidarUsuario();

        public CN_ValidarUsuario()
        {
        }

        public CN_ValidarUsuario(string username, string pass)
        {
            Username = username;
            Password = pass;
        }


        public bool ValidarNombreUsuarioL()
        {
            int digito = Seguridad.hasheo(Username, Password);
            bool existe = validarusuario.ValidarNombreUsuarioD(Username);
            if (existe && ComparaDigitoVerificador.ComparaDigito(digito, Username) == true )
>>>>>>> castel
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

<<<<<<< HEAD
            bool existe = validador.ValidarNombreUsuarioD(usuario);
=======
            bool existe = validarusuario.ValidarNombreUsuarioD(usuario);
>>>>>>> castel
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
