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
      // CS_AtributosPasajeros CN_Pasajero= new CS_AtributosPasajeros();

       public void CargarPax(CS_AtributosPasajeros pasajero) {

           CargarPasajero.AltaPasajero(pasajero);

       
       }
    }
}
