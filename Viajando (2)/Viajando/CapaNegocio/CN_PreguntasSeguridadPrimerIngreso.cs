using CapaDatos;
using CapaSesion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_PreguntasSeguridadPrimerIngreso
    {
        public PreguntasSeguridad[] PreguntasAleatorias()
        {
            PreguntasSeguridad[] preguntas = new CD_PreguntasAleatoriasPrimerIngreso().PreguntasAleatorias();
            
            if (preguntas != null)
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
