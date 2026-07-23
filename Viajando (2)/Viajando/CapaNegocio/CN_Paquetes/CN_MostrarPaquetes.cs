using CapaDatos;
using CapaSesion;
using System.Collections.Generic;
using System.Data;
using System.Globalization;

namespace CapaNegocio
{
    public class CN_MostrarPaquetes
    {
        CD_MostrarPaquete Paquete = new CD_MostrarPaquete();
        List<Paquete> Paquetes = new List<Paquete>();
        public List<Paquete> MostrarPaquetes( out string mensaje)
        {
            mensaje= string.Empty;
            Paquetes = null;
            Paquetes = Paquete.MostrarPaquetes(out mensaje);
            if (Paquetes != null)
            {
                return Paquetes;
            }
            else
            {
                return Paquetes;
            }
        }
    }
}
