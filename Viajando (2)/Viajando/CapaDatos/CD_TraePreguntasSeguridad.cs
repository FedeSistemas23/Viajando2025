using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_TraePreguntasSeguridad
    {
        List<string> preguntasSeguridad;
        public CD_TraePreguntasSeguridad()
        {
            preguntasSeguridad = new List<string>();
        }
        public List<string> TraePreguntasSeguridad(string username)
        {
            // Simulación de la obtención de preguntas de seguridad desde una base de datos
            // En un caso real, aquí se realizaría una consulta a la base de datos para obtener las preguntas
            if (username == "usuario1")
            {
                preguntasSeguridad.Add("¿Cuál es el nombre de tu primera mascota?");
                preguntasSeguridad.Add("¿Cuál es el nombre de tu escuela primaria?");
                preguntasSeguridad.Add("¿Cuál es tu comida favorita?");
            }
            else if (username == "usuario2")
            {
                preguntasSeguridad.Add("¿Cuál es el nombre de tu ciudad natal?");
                preguntasSeguridad.Add("¿Cuál es el nombre de tu mejor amigo de la infancia?");
                preguntasSeguridad.Add("¿Cuál es tu libro favorito?");
            }
            else
            {
                return null; // Usuario no encontrado
            }

            return preguntasSeguridad;
        }
    }
}
