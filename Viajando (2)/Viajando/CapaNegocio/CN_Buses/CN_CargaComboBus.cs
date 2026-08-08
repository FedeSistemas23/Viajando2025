using CapaDatos;
using CapaSesion;
using System.Collections.Generic;
using System;

namespace CapaNegocio
{
    public class CN_CargaComboBus
    {
        public List<Bus> CargaDatosBus(int id_bus, out string mensaje)
        {
            mensaje = string.Empty;

            List<Bus> busSelecionado = new CD_CargaComboBus().CargarComboBusD(id_bus, out mensaje);

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
