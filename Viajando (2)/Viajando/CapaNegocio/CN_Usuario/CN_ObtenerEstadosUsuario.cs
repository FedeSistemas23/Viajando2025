using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaDatos.CD_EstadosUsuario;
using CapaSesion;


namespace CapaNegocio.CN_Usuario
{
    public class CN_ObtenerEstadosUsuario:CN_EstadosUsuario
    {
        List<CS_EstadosUsuario> listaEstadosUsuario = new List<CS_EstadosUsuario> ();
        CD_ObtenerEstadoUsuario traerEstados = new CD_ObtenerEstadoUsuario ();

        public List<CS_EstadosUsuario> TraerEstadosCN()
        {
            listaEstadosUsuario = traerEstados.ObtenerEstadosCD();
            return listaEstadosUsuario;
        }

    }
}
