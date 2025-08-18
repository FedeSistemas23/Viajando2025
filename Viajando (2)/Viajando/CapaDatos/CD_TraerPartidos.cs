using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaSesion;

namespace CapaDatos
{
    public class CD_TraerPartidos:Conexion
    {
        List<CS_Partidos> ListaPartidosCS = new List<CS_Partidos>();
        public List<CS_Partidos> TraerPartidosCD() 
        {
            using (SqlConnection conn = AbrirConexion())
            {
                using(SqlCommand cmd = new SqlCommand("sp_TraerPartidos", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        try
                        {

                            while (reader.Read())
                            {
                                CS_Partidos partidoCS = new CS_Partidos
                                {
                                    Id_Partido = Convert.ToInt32(reader["ID_Partido"]),
                                    Partido = Convert.ToString(reader["Partido"]),
                                    Id_Provincia = Convert.ToInt32(reader["Id_Provincia"])
                                };
                                ListaPartidosCS.Add(partidoCS);
                            }
                            return ListaPartidosCS;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("MENASAJE DESDE CD_PARTIDOS : " + ex.ToString());
                            return ListaPartidosCS;
                        }
                    }
                }
            }
            
        }

    }
}
