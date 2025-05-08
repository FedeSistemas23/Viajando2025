using System;
using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{


    public class CD_ValidarUsuario : Conexion
    {
        public bool ValidarNombreUsuarioD(string username)
        {
            using (SqlConnection connection = AbrirConexion())
            using (SqlCommand cmd = new SqlCommand("ValidarUsuario", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Username", username);

                SqlParameter existeParam = new SqlParameter("@Existe", SqlDbType.Bit)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(existeParam);

                try
                {
                    cmd.ExecuteNonQuery();
                    return Convert.ToBoolean(existeParam.Value);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al ejecutar el procedimiento almacenado.\n\n" + ex.Message);
                }
                finally
                {
                    cmd.Parameters.Clear();
                    CerrarConexion();
                }
            }
        }
    }
}

