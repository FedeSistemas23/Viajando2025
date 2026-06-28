using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaSesion
{
    public class PagoTarjeta
    {
        public int IdPago { get; set; }

        public int Cuotas { get; set; }

        public string NumeroAutorizacion { get; set; }

        public string Ultimos4Digitos { get; set; }

        public string Titular { get; set; }
    }
}
