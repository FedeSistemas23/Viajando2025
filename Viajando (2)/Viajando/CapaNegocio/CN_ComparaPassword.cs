using CapaDatos;
using CapaSesion;
using Microsoft.SqlServer.Server;

namespace CapaNegocio
 
{
    public class CN_ComparaPassword
    {
        CD_ComparaPassword comparador;

        public CN_ComparaPassword()
        {
            comparador = new CD_ComparaPassword();
        }
        public bool ComparaPass(string username, string password)
        {
            string concatenados=password+username;
            string passwordHasheado = Seguridad.SHA256(concatenados);
            bool correcto = comparador.ComparaPassD(username, passwordHasheado);
            if (correcto)
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
