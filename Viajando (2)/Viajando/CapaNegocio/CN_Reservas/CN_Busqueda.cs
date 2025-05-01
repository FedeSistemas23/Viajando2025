using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class CN_Busqueda : CD_MostrarReserva
    {


        CD_MostrarReserva mostrarCN = new CD_MostrarReserva();
        CD_Busqueda objBusqueda = new CD_Busqueda();


        public DataTable ObtenerCoincidencias(string filtro)
        {
            return objBusqueda.BuscarPorCoincidencia(filtro);
        }

        public DataTable ObtenerCoincidenciasCN(int nroReserva)
        {
            return mostrarCN.MostrarPorNroReserva(nroReserva);
        }

        public DataTable MostrarReservasPorNombreCN()
        {
            return BuscarReservaPorNombre_CD();
        }
        public DataTable MostrarReservasPorApellidoCN()
        {
            return BuscarReservaPorApellido_CD();
        }

        public DataTable MostrarReservasPorFechaSalidaCN()
        {
            return BuscarReservaPorFechasalida_CD();
        }

        public DataTable MostrarReservasPorFechaReservaCN()
        {

            return BuscarReservaPorFechaReserva_CD();
        }

        public DataTable MostrarReservasPorDestinoCN()
        {
            return BuscarReservaPorDestino_CD();
        }
        public DataTable MostrarReservasPorNumReservaCN()
        {
            return BuscarReservaPorNumReserva_CD();
        }

        public DataTable MostrarReservasPorFechaRegresoCN()
        {
            return BuscarReservaPorFechaRegreso_CD();
        }
    }
}
