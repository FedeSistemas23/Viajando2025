using CapaDatos;
using CapaSesion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_EditarReserva:Reserva
    {
        public bool EditarReservaCN( Reserva reserva, out string mensaje)
        {
            mensaje = string.Empty;

            if (mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return new CD_EditarReserva().EditarReserva_CD( reserva, out mensaje);
            }    
        }
    }
}
