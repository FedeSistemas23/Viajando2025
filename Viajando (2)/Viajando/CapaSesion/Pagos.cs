using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaSesion
{
    public class Pagos
    {
        public int IdPago { get; set; }

        public int NroReserva { get; set; }

        public DateTime FechaPago { get; set; }

        public decimal Importe { get; set; }

        public int IdMedioPago { get; set; }

        public bool EsSena { get; set; }

        public string Observacion { get; set; }
    }
}
