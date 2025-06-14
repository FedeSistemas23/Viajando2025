using CapaDatos;
using CapaSesion;
using CapaServicios;

namespace CapaNegocio
{
    public class CN_ValidarUsuario
    {
        private string nombreusuario;
        string Username;
        private string Password;
        CD_ValidarUsuario validador;
        CN_ComparaDigitoVerificador comparador;

        public CN_ValidarUsuario()
        {
            comparador=new CN_ComparaDigitoVerificador();
            validador = new CD_ValidarUsuario();
        }

        public bool ValidarUsuarioL(string usuario, string pass)
        {
            bool existe = validador.ValidarNombreUsuarioD(usuario);

            if (existe && comparador.comparaDigitoVerificador(pass, usuario) == true )
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
