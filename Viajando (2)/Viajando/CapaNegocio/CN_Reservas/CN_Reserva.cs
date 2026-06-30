using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaSesion;  
        
namespace CapaNegocio
{
    public class CN_Reserva
    {   
        CD_Reserva reservaCD = new CD_Reserva();
        

        public bool GuardarReservaCN(Reserva reserva, out string mensaje)
        {
            mensaje = string.Empty;
            try
            {
                reservaCD.GuardarReserva(reserva, out mensaje);
                   return true;
                
            }catch(Exception ex)
            {
                
                return false;
            }
        }

        public bool EditarReservaCN(Reserva reserva, out string mensaje)
        {
            mensaje = string.Empty;

            if (mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return reservaCD.EditarReserva(reserva, out mensaje);
            }
        }


        public bool EliminarReservaCN(int NroReserva, out string mensaje)
        {

            mensaje = string.Empty;

            if (reservaCD.EliminarReserva(NroReserva, out mensaje))
                return true;
            else return false;
        }
    }
}
