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
    public class CN_MostrarReserva
    {
        CD_MostrarReservaDataGrid reservaCD = new CD_MostrarReservaDataGrid();
        CS_Reserva reservaCN = new CS_Reserva();
        public DataTable MostrarReservaCN(/*int NroReserva**/)
        {
            //int Nreserva = reserva.NroReserva;
            DataTable dt = new DataTable();
            dt=reservaCD.MostrarReservaDgv_CD(/*NroReserva*/);
            return dt;
        }
    }
}

        