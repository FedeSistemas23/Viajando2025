using CapaSesion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_TraePreguntasSeguridad : Conexion
    {
        public List<PreguntasSeguridad> PreguntasSeguridad(string username, out string mensaje)
        {
            mensaje = string.Empty;
            List<PreguntasSeguridad> lista = new List<PreguntasSeguridad>();

            try
            {
                using (SqlConnection connection = AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("PreguntasSeguridadUsuario ", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Username", username);

                        SqlParameter mensajeSalida = new SqlParameter("@Mensaje", SqlDbType.VarChar, 250);
                        mensajeSalida.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(mensajeSalida);

                        using (SqlDataReader leer = cmd.ExecuteReader())
                        {

                            while (leer.Read())
                            {
                                PreguntasSeguridad pregunta = new PreguntasSeguridad
                                {
                                    IdPregunta = leer.GetInt32(leer.GetOrdinal("Id_Preg")),
                                    Pregunta = leer["Pregunta"].ToString(),
                                    Activa = true, // O asigna el valor correcto según tu lógica
                                    IdUsuario = leer.GetInt32(leer.GetOrdinal("Id_Usuario"))
                                };
                                lista.Add(pregunta);
                            }
                        }
                        if (cmd.Parameters["@Mensaje"].Value != DBNull.Value)
                        {
                            mensaje = cmd.Parameters["@Mensaje"].Value.ToString();
                        }
                        return lista;
                    }
                }
                
            }
            catch (Exception ex)
            {
                mensaje = "Ocurrió un error inesperado en el sistema.";
                throw new Exception("Error en la capa de datos: " + ex.Message);
            } 
        }
    }  
}
        
    

