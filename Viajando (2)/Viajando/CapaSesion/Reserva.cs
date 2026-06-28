using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Linq.Expressions;

namespace CapaSesion
{
    public class Reserva
    {
        public int NroReserva { get; set; }
        public DateTime FechaReserva { get; set; }
        public DateTime FechaSalida { get; set; }
        public DateTime FechaRegreso { get; set; }
        public int Id_Vendedor { get; set; }
        public Paquete Id_Paquete { get; set; }
        public string NombreTitular { get; set; }
        public string ApellidoTitular { get; set; }
        public string AscensoMicro { get; set; }
        public bool Cotizar { get; set; }
        public string Observacion { get; set; }
        public EstadoReserva IdEstado { get; set; }

        public List<ReservaPasajero> Pasajeros { get; set; } 
        public List<ReservaHabitacion> Habitaciones { get; set; }

        public List<ReservaAsiento> Asientos { get; set; } 

        public List<Pagos> Pagos { get; set; } 
    }
}




    

