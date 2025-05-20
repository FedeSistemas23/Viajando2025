using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_ComparaPassword
    {
        public bool ComparaPassD(string username, string passwordHasheado)
        {
            try
            {
                using (SqlConnection connection = new Conexion().AbrirConexion())
                using (SqlCommand cmd = new SqlCommand("VerificarPassword", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Pass", passwordHasheado);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int resultado = reader.GetInt32(reader.GetOrdinal("Resultado"));
                            return resultado == 1;
                        }
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar el procedimiento almacenado o al conectar con la base de datos.\n\n" + ex.Message);
            }
        }
    }
}
