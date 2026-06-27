using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaSesion
{
    public class Disponibilidad
    {
        public int Id_Disponibilidad { get; set; }

        public int Id_Paquete { get; set; }

        public int CuposTotales { get; set; }

        public int CuposDisponibles { get; set; }

    }
}
