using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Policy;
using CapaSesion;

namespace CapaDatos
{
    public class CD_CargaComboBus : Conexion
    {
        public List<Bus> CargarComboBusD(int id_destino, out string mensaje)
        {
            List<Bus> listaBuses = new List<Bus>();
            mensaje = string.Empty;

            try
            {
                using (SqlConnection connection = AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("CargaComboBus", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Parámetro de entrada
                        cmd.Parameters.Add("@Id_Destino", SqlDbType.Int).Value = id_destino;

                        // Parámetro de salida
                        cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500)
                            .Direction = ParameterDirection.Output;

                        using (SqlDataReader leer = cmd.ExecuteReader())
                        {
                            while (leer.Read())
                            {
                                listaBuses.Add(new Bus()
                                {
                                    Cama = Convert.ToBoolean(leer["Cama"]),
                                    Semicama = Convert.ToBoolean(leer["Semicama"]),
                                    Suite = Convert.ToBoolean(leer["Suite"]),
                                    AsientosCama = Convert.ToInt32(leer["AsientosCama"]),
                                    AsientosSemicama = Convert.ToInt32(leer["AsientosSemicama"])
                                });
                            }
                        }

                        // IMPORTANTE:
                        // El parámetro OUTPUT se obtiene después de cerrar el reader
                        mensaje = cmd.Parameters["@Mensaje"].Value?.ToString() ?? string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje = "Error al cargar los buses: " + ex.Message;
            }
            return listaBuses;
        }
    }
}


