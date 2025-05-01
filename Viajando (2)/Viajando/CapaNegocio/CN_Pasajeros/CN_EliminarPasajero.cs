using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_EliminarPasajero
    {
        CD_EliminarPasajero EliminarPasajero = new CD_EliminarPasajero();
        

        public void EliminarPasajeroL(int id_pasajero)
        {
            EliminarPasajero.EliminarPasajeroD(id_pasajero);
        }
    }
}
