using CapaDatos;
using CapaSesion;

namespace CapaNegocio
{
    public class CN_ComparaDigitoVerificador
    {

        public bool ComparaDigito(string username, string password)
        {
            int digito = Seguridad.hasheo(username, password);
            CD_ComparaDigitoVerificador comparador = new CD_ComparaDigitoVerificador();
            bool correcto = comparador.ComparaDigitoD(digito, username);
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
