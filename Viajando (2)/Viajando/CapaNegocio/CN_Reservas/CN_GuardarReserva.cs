using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaSesion;  
        
namespace CapaNegocio
{
    public class CN_GuardarReserva
    {   CD_GuardarReserva reservaCD = new CD_GuardarReserva();
        CS_Reserva reservaCN = new CS_Reserva();

        public bool GuardarReservaCN(CS_Reserva reserva)
        {
            try
            {
                reservaCD.GuardarReserva_CD(reserva);
                   return true;
                
            }catch(Exception ex)
            {
                
                return false;
            }
        }
    }
}
