using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaSesion
{
    public class Persona
    {
        public int IdPersona { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public string DNI { get; set; }

        public string Email { get; set; }

        public string Telefono { get; set; }

        public string Celular { get; set; }

        public string Provincia { get; set; }

        public string Partido { get; set; }

        public string Localidad { get; set; }

        public string Calle { get; set; }

        public string Numero { get; set; }

        public bool Activo { get; set; }

    }
}
