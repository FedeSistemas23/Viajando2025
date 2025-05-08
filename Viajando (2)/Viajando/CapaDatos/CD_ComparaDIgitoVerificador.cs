using CapaSesion;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;

namespace CapaDatos
{
    public class CD_ComparaDigitoVerificador
    {
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
            }
        }
    }
}
