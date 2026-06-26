using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaSesion;

namespace CapaNegocio
{
    public class CN_CargarComboDestino
    {
        CD_CargarComboDestinos destino = new CD_CargarComboDestinos();
        public List<Destino> CargarComboDestinosL( out string mensaje)
        {
            string mensaje = string.Empty;
            List<Destino> lista = new List<Destino>(destino.CargarComboDestinosD(mensaje));
           
            
            if (destino != null)
            {
                return lista;
            }
            else
            {
                return null;
            }
        }
    }
}
