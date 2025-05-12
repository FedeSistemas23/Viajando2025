using CapaDatos;
<<<<<<< HEAD
=======
using CapaSesion;
using CapaServicios;
>>>>>>> origin/castel

namespace CapaNegocio
{
    public class CN_ValidarUsuario
    {
<<<<<<< HEAD
        private readonly string nombreusuario;
        private readonly string Username;
        private readonly string Password;
        private readonly int digito;

        CN_ComparaDigitoVerificador comparador;
        CD_ValidarUsuario validarusuario;
        CN_ComparaPassword comparadorPass;
=======
        private string nombreusuario;
        string Username;
        private string Password;
        CD_ValidarUsuario validarusuario = new CD_ValidarUsuario();
>>>>>>> origin/castel

        public CN_ValidarUsuario()
        {
        }

        public CN_ValidarUsuario(string username, string pass)
        {
            Username = username;
            Password = pass;
<<<<<<< HEAD
            comparador = new CN_ComparaDigitoVerificador();
            validarusuario = new CD_ValidarUsuario();
            comparadorPass=new CN_ComparaPassword();
=======
>>>>>>> origin/castel
        }


        public bool ValidarNombreUsuarioL()
        {
<<<<<<< HEAD

            bool existe = validarusuario.ValidarNombreUsuarioD(Username);
            if (existe/* && comparador.ComparaDigito(Username, Password)== true*/ && comparadorPass.ComparaPass(Username, Password) == true)
=======
            int digito = Seguridad.hasheo(Username, Password);
            bool existe = validarusuario.ValidarNombreUsuarioD(Username);
            if (existe && ComparaDigitoVerificador.ComparaDigito(digito, Username) == true )
>>>>>>> origin/castel
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
