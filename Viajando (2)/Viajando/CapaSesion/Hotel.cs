namespace CapaSesion
{
    public class Hotel
    {
        public int Id_ProvedorHotel {  get; set; } 
        public string Destino {  get; set; }
        public string NombreDelHotel { get; set; }
        public string NombreTitularHotel { get; set; }
        public string ApellidoTitularHotel { get; set; }
        public string Cuit { get; set; }
        public string Calle { get; set; }
        public int Numero { get; set; }
        public string Localidad { get; set; }
        public string Partido { get; set; }
        public string Provincia { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public int CantidadDeHabitaciones { get; set; }
        public int HabitacionesSingle { get; set; }
        public int HabitacionesDoble { get; set; }
        public int HabitacionesTriple { get; set; }
        public int HabitacionesCuadruple { get; set; }
        public string Regimen { get; set; }
        public bool Desayuno { get; set; }
        public bool MediaPension { get; set; }
        public bool PensionCompleta { get; set; }
        public int Id_Destino { get; set; }
    }
}
