using CapaSesion;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;

namespace CapaDatos
{
    public class CD_ComparaDigitoVerificador
    {
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
                        else
                    {
                        // Si no se encontraron filas (por ejemplo, usuario no existe), devolvemos false
                        return false;
                    }
                }

                    return true; // Usuario válido
                }
                else
                {
                    return false; /*Usuario no encontrado*/
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
            }
        }
    }
}
