using CapaDatos;
using CapaSesion;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CN_CargaComboHotel
    {
               
        public List<Hotel> CargaCmbHotel(Destino nombre, out string mensaje)
        {
            List<Hotel> Hoteles =  new CD_CargaComboHotel().CargarComboHotelD(nombre, out mensaje);
            if (Hoteles != null)
            {
                return Hoteles;
            }
            else
            {
                return null;
            }
        }

        public List
    }
}
