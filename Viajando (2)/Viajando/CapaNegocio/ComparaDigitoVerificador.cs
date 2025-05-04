using CapaDatos;

namespace CapaServicios
{
    public  class ComparaDigitoVerificador
    {
        
        public bool ComparaDigito(int digito, string username)
        {
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
