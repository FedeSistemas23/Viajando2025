using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaSesion;

namespace CapaNegocio
{
    public class CN_TraerPartidos
    {
        CD_TraerPartidos partidosCd = new CD_TraerPartidos();
        List<CS_Partidos> listaPartidos = new List<CS_Partidos>();

        public List<CS_Partidos> TraerPartidosCN()
        {
            try
            {
              listaPartidos = partidosCd.TraerPartidosCD().ToList();
                return listaPartidos;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR AL TRAER PARTIDOS_CN :" + ex.Message.ToString());
            }
            return listaPartidos;
        }
    }
}
