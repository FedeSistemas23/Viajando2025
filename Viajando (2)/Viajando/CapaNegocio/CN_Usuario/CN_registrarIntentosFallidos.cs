using CapaDatos;

namespace CapaNegocio
{
    public class CN_registrarIntentosFallidos
    {
        CD_IntentosFallidos intentoFallido = new CD_IntentosFallidos();
        public void registraIntentofallidoL(string username, int nuevointento)
        {
            intentoFallido.ActualizaIntentosFallidosD(username, nuevointento);
        }
    }
}
