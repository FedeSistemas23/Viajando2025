using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaSesion
{
    public class PagoTransferencia
    {
        public int IdPago { get; set; }

        public string Banco { get; set; }

        public string Alias { get; set; }

        public string CBU { get; set; }

        public string NumeroOperacion { get; set; }
    }
}
