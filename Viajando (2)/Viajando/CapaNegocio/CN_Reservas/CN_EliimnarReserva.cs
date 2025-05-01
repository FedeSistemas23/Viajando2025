using CapaDatos;

namespace CapaNegocio
{
    public class CN_ElimnarReserva : CD_EliminarReserva
    {

        CD_EliminarReserva EliminarPaquete = new CD_EliminarReserva();
        public bool EliminarReservaCN(int NroReserva)
        {
            if (EliminarPaquete.EliminarReservaCD(NroReserva))
                return true;
            else return false;
        }

    }
}
