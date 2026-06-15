using CapaDatos;
using CapaSesion;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CN_CargaComboBus
    {
        CD_CargaComboBus bus = new CD_CargaComboBus();
        

        public List<Bus> CargadorComboBusL(Destino destino)
        {
            List<Bus> listaBuses = bus.CargadorComboBusD(destino);

            if (listaBuses == null)
            {
                return null;
            }
            else
            {
                return listaBuses;
            }
        }
    }
}
