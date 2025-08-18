using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaSesion;

namespace CapaDatos.CD_EstadosUsuario
{
    public class CD_ObtenerEstadoUsuario:Conexion
    {
        public List<CS_EstadosUsuario> ObtenerEstadosCD()
        {
            List<CS_EstadosUsuario> lista = new List<CS_EstadosUsuario>();

            using (SqlConnection conn = AbrirConexion())
            {
                string query = "SELECT Id, Nombre FROM EstadoUsuario";
                SqlCommand cmd = new SqlCommand(query, conn);
               
               
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        CS_EstadosUsuario estado = new CS_EstadosUsuario
                        {
                            Id = Convert.ToInt32(dr["Id"]),
                            Nombre = dr["Nombre"].ToString()
                        };
                        lista.Add(estado);
                    }
                }
            }
            
            return lista;
        }

    }
}
