using CapaDatos;
using CapaSesion;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CN_CargaComboHotel
    {
               
        public List<Hotel> cargaComboHotel(Destino nombre)
        {
            List<Hotel> Hoteles =  new CD_CargaComboHotel().CargarComboHotelD(nombre);
            if (Hoteles != null)
            {
                return Hoteles;
            }
            else
            {
                return null;
            }
        }
    }
}
