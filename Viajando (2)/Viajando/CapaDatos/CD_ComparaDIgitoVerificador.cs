using CapaSesion;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;

namespace CapaDatos
{
    public class CD_ComparaDigitoVerificador
    {
<<<<<<< HEAD
        private readonly Conexion conn = new Conexion();

        public bool ComparaDigitoD(int digito, string username)
        {
            using (SqlConnection connection = conn.AbrirConexion())
            using (SqlCommand cmd = new SqlCommand("VerificarDigitoUsuario", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                // Parámetros de entrada
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@DigitoIngresado", digito);

                // Parámetro de salida
                SqlParameter esValidoParam = new SqlParameter("@EsValido", SqlDbType.Bit)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(esValidoParam);

                try
                {
                    cmd.ExecuteNonQuery();

                    // Convertimos el valor de salida a bool
                    return Convert.ToBoolean(esValidoParam.Value);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al ejecutar el procedimiento almacenado: " + ex.Message);
                }
                finally
                {
                    conn.CerrarConexion();
                }
=======
        Conexion conn = new Conexion();
        SqlCommand cmd = new SqlCommand();
        public bool ComparaDigitoD(int digito, string username)
        {
            int Digito = digito;
            try
            {
                cmd.Connection = conn.AbrirConexion();
                cmd.CommandText = "CompararDigito";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Digito", Digito);
                SqlDataReader leer = cmd.ExecuteReader();
                if (leer.HasRows)
                {
                    leer.Read();
                    {
                        // Obtiene el valor de la columna "Resultado" (que será 1 o 0)
                        int resultado = leer.GetInt32(leer.GetOrdinal("Resultado"));

                        // Devuelve true si el resultado es 1, false si es 0
                        return resultado == 1;
                    }
                       
                } else
                    {
                        // Si no se encontraron filas (por ejemplo, usuario no existe), devolvemos false
                        return false;
                    }

                  

            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar SP o Conexion a la BD. \n \n" + ex.Message);
            }
            finally
            {
                cmd.Parameters.Clear();
                conn.CerrarConexion();
>>>>>>> origin/castel
            }
        }
    }
}
