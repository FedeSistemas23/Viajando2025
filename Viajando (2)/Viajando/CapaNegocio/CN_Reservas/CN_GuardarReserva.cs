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
        Reserva reservaCN = new Reserva();

        public bool GuardarReservaCN(Reserva reserva)
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
