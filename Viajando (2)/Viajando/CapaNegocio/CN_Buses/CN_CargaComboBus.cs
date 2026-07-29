using CapaDatos;
using CapaSesion;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CN_CargaComboBus
    {
        public Bus CargaDatosBus(int id_bus, out string mensaje)
        {
            mensaje = string.Empty;

            Bus busSelecionado = new CD_CargaComboBus().CargarDatosBusD(id_bus, out mensaje);

            if (busSelecionado != null)
            {
                return busSelecionado;
            }
            else
            {
                mensaje += "No exiten buses en ese Destino. Debe cargarlos primero";
                return null;    
            }
            
        }
    }
}
