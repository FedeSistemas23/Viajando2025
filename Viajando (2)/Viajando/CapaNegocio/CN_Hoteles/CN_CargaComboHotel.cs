using CapaDatos;
using CapaSesion;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CN_CargaComboHotel
    {     
        public List<Hotel> CargaComboHotelL(int id_hotel, out string mensaje)
        {
            mensaje = string.Empty;

            List<Hotel> Hoteles = new CD_CargaComboHotel().CargarComboHotelD(id_hotel, out mensaje);
            
            if (Hoteles != null)
            {
                mensaje += "Hoteles cargados correctamente.";
            }
            else
            {
                mensaje += "No exiten hoteles en ese Destino. Debe cargarlosm primero";  
            }
            return Hoteles;
        }
    }
}
