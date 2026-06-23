using CapaDatos;
using CapaSesion;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CN_CargaComboBus
    {
        public List<Bus> CargaComboBusL(int id_bus, out string mensaje)
        {
            mensaje = string.Empty;

            List<Bus> Buses = new CD_CargaComboBus().CargarComboBusD(id_bus, out mensaje);

            if (Buses != null)
            {
                mensaje += "Buses cargados correctamente.";
            }
            else
            {
                mensaje += "No exiten buses en ese Destino. Debe cargarlos primero";
            }
            return Buses;
        }
    }
}
