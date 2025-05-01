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
    public class CN_EditarReserva:CS_Reserva
    {
        readonly bool permitirEditar = true;
        CD_EditarReserva editar = new CD_EditarReserva();

        public bool EditarReservaCN(CS_Reserva reserva )
        {
            if( editar.EditarReserva_CD(reserva))
                   return true;
                    return false;
            
        }
    }
}
