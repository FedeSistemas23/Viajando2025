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
    public class CN_BuscarPaquete
    {
        CD_BuscarPaquete paqueteCD = new CD_BuscarPaquete();  
        Paquete CamposPaquete = new Paquete();
        DataTable dt = new DataTable();

        public DataTable BuscarPaqueteCN(Paquete parametros)
        {
            dt = paqueteCD.BuscarPaqueteCD(parametros);
            return dt;
        }
    }
}
