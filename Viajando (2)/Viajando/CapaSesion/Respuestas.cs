using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaSesion
{
    public class Respuestas
    {

        public int IdUsuario { get; set; }

        public int IdPregunta { get; set; }

        public string Respuesta{ get; set; }


        public PreguntasSeguridad Pregunta { get; set; }

    }
}
