using CapaDatos;
using CapaSesion;
using CapaServicios;
using CapaNegocio;
using CapaNegocio.CN_Usuario;

namespace CapaNegocio
{
    public class CN_ValidarUsuario
    {
        private string nombreusuario;
        string Username;
        private string Password;
        CD_ValidarUsuario validador;
        CN_ComparaDigitoVerificador comparador;
        CN_ComparaPassword comparaPass;

        public CN_ValidarUsuario()
        {
            comparador=new CN_ComparaDigitoVerificador();
            validador = new CD_ValidarUsuario();
            comparaPass=new CN_ComparaPassword();
        }

        public bool ValidarUsuarioL(string usuario, string pass)
        {
            bool existe = validador.ValidarNombreUsuarioD(usuario);

            if (existe && comparador.comparaDigitoVerificador(pass, usuario) 
                && comparaPass.comparaPassword(pass) 
                && verificadorBloqueo.VerificarUsuarioBloqueado())
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
