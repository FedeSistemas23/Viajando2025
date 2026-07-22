using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaSesion
{
    public class PreguntasSeguridad
    {

        /*public static string respuesta1 { get; set; }   
        public static int id_preg1 {  get; set; }
        
        public static string respuesta2 { get; set; }
        public static int id_preg2 { get; set; }
        public static string respuesta3 { get; set; }
        public static int id_preg3 { get; set; }
        */
        public int IdUsuario { get; set; }
        public int IdPregunta { get; set; }
        public string Respuesta { get; set; }

        public string Pregunta { get; set; }

        public bool Activa { get; set; }

    }
}
