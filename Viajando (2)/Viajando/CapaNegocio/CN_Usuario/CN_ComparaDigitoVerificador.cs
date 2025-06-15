using CapaDatos;
using CapaSesion;

namespace CapaServicios
{
    public class CN_ComparaDigitoVerificador
    {
        CD_ComparaDigitoVerificador comparador;
        public CN_ComparaDigitoVerificador() { comparador = new CD_ComparaDigitoVerificador(); }
        
        public bool comparaDigitoVerificador(string pass, string Usuario)
        {
            string concatenados =pass+Usuario;
            string hasheo = Seguridad.SHA256(concatenados);
            int digito = CreaDigitoVerificador.Calcular(hasheo);
            //bool correcto = comparador.ComparaDigitoD(digito, Usuario);
            if (digito==CS_UsuarioEnSesion.Digito)
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
