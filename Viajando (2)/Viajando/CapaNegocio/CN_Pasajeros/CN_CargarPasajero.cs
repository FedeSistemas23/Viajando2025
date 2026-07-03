using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaSesion;

namespace CapaNegocio
{
   public class CN_CargarPasajero
    {
       CD_CargarPasajero CargarPasajero = new CD_CargarPasajero();
      

       public void CargarPax(Pasajero pasajero) {

           CargarPasajero.AltaPasajero(pasajero);
       }
    }
}
