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
        readonly bool permitirEditar = true;
        CD_EditarReserva editar = new CD_EditarReserva();

        public bool EditarReservaCN(Reserva reserva )
        {
            if( editar.EditarReserva_CD(reserva))
                   return true;
                    return false;
            
        }
    }
}
