using CapaDatos;
using CapaSesion;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CN_CargaComboHotel
    { 
        string mensaje = string.Empty;

        public List<Hotel> CargaComboHotel(Destino nombre, out string mensaje)
        {
            List<Hotel> Hoteles = new CD_CargaComboHotel().CargarComboHotelD(nombre, out string mensaje);
            if (Hoteles != null)
            {
                return Hoteles;

            }
            else
            {
                
                 return mensaje;
            }
           
        }
        public List<Hotel> CargaComboHotelL(string nombre, out string mensaje)
        {
            List<Hotel> Hoteles = new CD_CargaComboHotel().CargarComboHotelD(nombre, out string mensaje);
            if (Hoteles != null)
            {
                return Hoteles;

            }
            else
            {
                mensaje = "No se han encontrado hoteles para el destino seleccionado.";

            }
            return mensaje;
        }

    }
}
