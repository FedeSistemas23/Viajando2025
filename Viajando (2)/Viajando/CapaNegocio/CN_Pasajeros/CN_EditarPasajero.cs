using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaSesion;

namespace CapaNegocio
{
    public class CN_EditarPasajero
    {
        CD_EditarPasajero EditarPax = new CD_EditarPasajero();
        public void EditarPasajeroL(CS_AtributosPasajeros pasajero)
        {
            EditarPax.EditarPasajeroD(pasajero);
        }
    }
}
