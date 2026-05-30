using CapaDatos;
using CapaSesion;
using System.Collections.Generic;
using System.Data;

namespace CapaNegocio
{
    public class CN_MostrarPaquetes
    {
        CD_MostrarPaquete Paquete = new CD_MostrarPaquete();
        List<Paquete> Paquetes = new List<Paquete>();
        public List<Paquete> MostrarPaquetes()
        {
            Paquetes = null;
            Paquetes = Paquete.MostrarPaquetes();
            if (Paquetes != null)
            {
                return Paquetes;
            }
            else
            {
                return null;
            }
        }
    }
}
