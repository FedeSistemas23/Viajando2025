using CapaDatos;
using CapaSesion;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CN_TraePreguntasSeguridad
    {
        CD_TraePreguntasSeguridad obj;
        

        public CN_TraePreguntasSeguridad() 
        {
            obj = new CD_TraePreguntasSeguridad();    
        }

        public List<PreguntasSeguridad> TraerPreguntas(string username, out string mensaje)
        {
            mensaje = string.Empty;
            
            List<PreguntasSeguridad> lista= obj.PreguntasSeguridad(username, out mensaje);
            
            if (lista != null)
            {
                return lista;
            }
            else
            {
                return lista;
            }       
        }
    }
}
