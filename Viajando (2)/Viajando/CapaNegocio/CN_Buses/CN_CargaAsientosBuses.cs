using CapaDatos;
using CapaSesion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_CargaAsientosBuses
    {
        CD_CargaAsientosBus CargadorAsientos= new CD_CargaAsientosBus();
        List<int> asientos = new List<int>();
        public List<int> CargaAsientosBusL(string nombrebus, out string mensaje)
        {
            mensaje = string.Empty;

            asientos = CargadorAsientos.CargaAsientosBusD(nombrebus);
            if (mensaje != string.Empty)
            {
                return null;
            }

            else
            {
               // return GuardarNuevoPaqueteD.GuardarPaqueteD(paquete, out mensaje);
            }
        }
    }
}
