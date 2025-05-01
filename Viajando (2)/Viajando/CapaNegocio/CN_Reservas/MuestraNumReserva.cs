using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
namespace CapaNegocio
{
    public class MuestraNumReserva 
    {
        CD_TraeNumReserva reservaCN = new CD_TraeNumReserva();
        CD_TraeIdPax pasajeroCD = new CD_TraeIdPax();

        public int MostrarNumReservaCN()
        {
           // try
            //{
                int Nreserva = reservaCN.TraerNumReserva();
                Console.WriteLine("Numero de reserva : ", Nreserva);
                //if (Nreserva = 0)
              //  {
                    return Nreserva + 2;

                
               // else return 0;
           // }
            //catch { return 0; }
   
        }

        public int TraeIdPax()
        {
            try
            {
                int NumPasajero = pasajeroCD.ObtenerIdPasajero();
                return NumPasajero;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en CN_Muestra Reserva para obtener el id Pasajer : " + ex.ToString());
                return 0;
            }
        }
        
    }
}
