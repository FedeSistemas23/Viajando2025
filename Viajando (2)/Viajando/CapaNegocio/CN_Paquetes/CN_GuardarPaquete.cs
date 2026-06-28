using CapaDatos;
using CapaSesion;
using System;

namespace CapaNegocio
{
    // Esta clase agrega en una lista, los datos provenientes del formulario de Ingresar Paquete
    // y luego los envia a la capa de datos para guardarlos en la base de datos
    public class CN_GuardarPaquete
    {
        
        
        private CD_GuardarPaquete GuardarNuevoPaqueteD = new CD_GuardarPaquete();
       
        
        public int GuardarNuevoPaquete(Paquete paquete, out string mensaje)
        {
            mensaje = string.Empty;

            if (paquete.FechaRegreso == default && paquete.FechaSalida == default)
            {
                mensaje += "Tiene que selecionar las fechas validas";

            }

            if ((string.IsNullOrEmpty(paquete.Destino.Nombre)))
            {
                mensaje = "Tiene que selecionar un Destino";
            }
            if (mensaje != string.Empty)
            {
                return 0;
            }

            else
            {
                return GuardarNuevoPaqueteD.GuardarPaqueteD(paquete, out mensaje);
            }
        }
    }
}
