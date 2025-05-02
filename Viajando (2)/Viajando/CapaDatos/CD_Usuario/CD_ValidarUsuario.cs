using CapaSesion;
using System;
using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{


    public class CD_ValidarUsuario : Conexion
    {
        Conexion conn = new Conexion();
        SqlCommand cmd = new SqlCommand();
        public bool ValidarNombreUsuarioD(string username)
        {

            try
            {
                cmd.Connection = conn.AbrirConexion();
                cmd.CommandText = "ValidarUsuario";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Username", username);
                SqlDataReader leer = cmd.ExecuteReader();
                if (leer.HasRows)
                {
                    while (leer.Read())
                    {
                        CS_UsuarioEnSesion.Id_Usuario = leer.GetInt32(leer.GetOrdinal("Id_Usuario"));
                        CS_UsuarioEnSesion.Username = leer["Username"].ToString();
                        CS_UsuarioEnSesion.Apellido = leer["Apellidos"].ToString();
                        CS_UsuarioEnSesion.Nombre = leer["Nombre"].ToString();
                        if (leer["Id_Familia"] != DBNull.Value && int.TryParse(leer["Id_Familia"].ToString(), out int idFamilia))
                        {
                            CS_UsuarioEnSesion.Id_Familia = idFamilia;
                        }
                        else
                        {
                            // Manejar el caso en que el valor es nulo o no es un entero válido
                            CS_UsuarioEnSesion.Id_Familia = 0; // O algún otro manejo adecuado
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

