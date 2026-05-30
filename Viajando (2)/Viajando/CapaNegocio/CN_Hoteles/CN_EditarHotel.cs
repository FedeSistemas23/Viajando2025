using CapaSesion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class CN_EditarHotel
    {
        readonly CD_EditarHotel HotelEditado = new CD_EditarHotel();
        
        public void EditarHotelL(Hotel hotel)
        {
            HotelEditado.EditarHotelD(hotel);
        }
    }
}
