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
    public class CD_PreguntasAleatoriasPrimerIngreso : Conexion
    {
        public PreguntasSeguridad[] PreguntasAleatorias()
        {
            PreguntasSeguridad[] preguntasAleatorias = new PreguntasSeguridad[3];

            try
            {
                using (SqlConnection connection = AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("PreguntasAleatorias", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader leer = cmd.ExecuteReader())
                        {
                           
                            while (leer.Read())
                            {
                                PreguntasSeguridad pregunta = new PreguntasSeguridad
                                {
                                    IdPregunta = leer.GetInt32(leer.GetOrdinal("Id_Preg")),
                                    Pregunta = leer["Pregunta"].ToString(),
                                    Activa = true // O asigna el valor correcto según tu lógica
                                };
                            }
                        }
                    }
                }
                return preguntasAleatorias;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar SP o Conexion a la BD. \n \n" + ex.Message);
            }
        }
    }
}
