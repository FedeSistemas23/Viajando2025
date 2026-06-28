using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaSesion
{
    public class ReservaPasajero
    {
        public int IdReservaPasajero { get; set; }

        public int NroReserva { get; set; }

        public int IdPasajero { get; set; }

        public bool EsTitular { get; set; }

        public bool EsMenor { get; set; }
    }
}
