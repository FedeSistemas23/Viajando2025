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
        public List<Destino> CargarComboDestinosL(out string mensaje)
        {
            return new CD_CargarComboDestinos().CargarComboDestinosD(out mensaje);
        }
    }
}
