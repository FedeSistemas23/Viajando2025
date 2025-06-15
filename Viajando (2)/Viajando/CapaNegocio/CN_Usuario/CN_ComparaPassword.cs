using CapaSesion;

namespace CapaNegocio.CN_Usuario
{
    public class CN_ComparaPassword
    {
        public CN_ComparaPassword() { }
        public bool comparaPassword(string password)
        {
            if (password == CS_UsuarioEnSesion.password)
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
