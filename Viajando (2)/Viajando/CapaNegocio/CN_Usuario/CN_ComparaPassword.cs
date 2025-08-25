using CapaSesion;

namespace CapaNegocio.CN_Usuario
{
    public class CN_ComparaPassword
    {
        public CN_ComparaPassword() { }
        public bool ComparaPassword(string pass, string usuario)
        {
            string concatenados = pass +usuario;
            string hasheo = Seguridad.SHA256(concatenados);
            if (hasheo == CS_UsuarioEnSesion.password)
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
