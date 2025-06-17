using CapaDatos;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CN_TraePreguntasSeguridad
    {
        CD_TraePreguntasSeguridad traedorPreguntas;
        List<string> preguntas;

        public CN_TraePreguntasSeguridad() 
        {
            traedorPreguntas = new CD_TraePreguntasSeguridad();
            preguntas = new List<string>();
        }

        public List<string> TraerPreguntas(string username)
        {
            preguntas = null;
            preguntas = traedorPreguntas.TraePreguntasSeguridad(username);
            if(preguntas != null)
            {
                return preguntas;
            }
            else
            {
                return null;
            }

            
        }
    }
}
