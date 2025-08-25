using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaSesion;
using System.Data;

namespace CapaDatos
{
   public class CD_TraerProvincias:Conexion
   {
        public List<CS_Provincias> TraerProvinciasCD()
        {
            List<CS_Provincias> listaProvincias = new List<CS_Provincias>();

            using (SqlConnection conn = AbrirConexion())
            {
                using (SqlCommand cmd = new SqlCommand("sp_TraerProvincias", conn))
                {

                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        try
                        {
                            while (reader.Read())
                            {
                                CS_Provincias provincia = new CS_Provincias
                                {
                                   // Id_Provincia = reader.GetInt32(0),
                                   // Provincia = reader.GetString(1)
                                   // Id_Pais = reader.GetInt32(2),
                                    Id_Provincia = Convert.ToInt32(reader["Id_Provincia"]),
                                     Provincia = Convert.ToString(reader["Provincia"]),
                                    // Id_Pais = Convert.ToInt32(reader["Id_Pais"])*/
                                };
                               listaProvincias.Add(provincia);
                            }
                            return listaProvincias;
                        }
                        catch (Exception ex)
                        { 
                            Console.WriteLine("ERROR AL TRAER PROVINCIAS DESDE BBDD, CD_PROVINCIAS"+ex.Message.ToString());
                            return listaProvincias;
                        }
                    }          
                }
            }
        }
   }
}
