using System;

namespace CapaSesion
{
    public class Paquete
    {
        public int Id_Paquete { get; set; }
        public DateTime FechaSalida { get; set; }
        public DateTime FechaRegreso { get; set; }
        public Destino Destino { get; set; }
        public int CantidadDias { get; set; }
        public int CantidadNoches { get; set; }
        public int Disponibilidad { get; set; }

        public Hotel ProveedorHotel { get; set; }
        public Bus ProveedorBus { get; set; }
        public decimal GastosAdministrativos { get; set; }
        public decimal PrecioLista { get; set; }
        public decimal PrecioEfectivo { get; set; }
        public decimal Coste { get; set; }
        public string Estado {  get; set; }
        
    }
}
