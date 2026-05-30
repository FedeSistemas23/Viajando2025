using CapaDatos;
using CapaSesion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_MostrarBuses
    {
        CD_MostrarBuses MostradorBuses;
        List<Bus> Buses;
        public CN_MostrarBuses()
        {
             MostradorBuses = new CD_MostrarBuses();
            Buses = new List<Bus> ();
        }
        
        public List<Bus> MostrarBusesL()
        {
            Buses=null;
            Buses = MostradorBuses.MostrarBusesD();
            if (Buses == null)
            {
                return null;
            }
            else
            {
                return Buses;
            }
        }
    }
}
