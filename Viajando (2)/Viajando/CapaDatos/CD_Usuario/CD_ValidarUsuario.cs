using CapaSesion;
using System;
using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class CD_ValidarUsuario : Conexion
    {
        public bool ValidarNombreUsuarioD(string username)
        {
            try
            {
                using (SqlConnection connection = AbrirConexion())
                using (SqlCommand cmd = new SqlCommand("ValidarUsuario", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Username", username);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                CS_UsuarioEnSesion.Id_Usuario = reader.GetInt32(reader.GetOrdinal("Id_Usuario"));
                                CS_UsuarioEnSesion.Username = reader["Username"].ToString();
                                CS_UsuarioEnSesion.Apellido = reader["Apellidos"].ToString();
                                CS_UsuarioEnSesion.Nombre = reader["Nombre"].ToString();
                                CS_UsuarioEnSesion.password = reader["Pass"].ToString();
                                CS_UsuarioEnSesion.Digito = Convert.ToInt32(reader["Digito"]);
                                // Manejo del valor Id_Familia
                               // object idFamiliaValue = reader["Id_Familia"];
                                //CS_UsuarioEnSesion.Id_Familia = (idFamiliaValue != DBNull.Value && int.TryParse(idFamiliaValue.ToString(), out int idFamilia))
                                   // ? idFamilia
                                    //: 0;
                            }
                            return true;
                        }
                        else
                        {
                            return false; // Usuario no encontrado
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al validar el usuario: " + ex.Message, ex);
            }
            finally
            {
                CerrarConexion();
            }
        }
    }
}

