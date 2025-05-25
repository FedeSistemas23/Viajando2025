using CapaSesion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_AltaUsuario : Conexion
    {
        public void GuardarUsuarioD(CN_Nuevo_Usuario usuario)
        {
            List<CN_Nuevo_Usuario> lista = new List<CN_Nuevo_Usuario>();
            try
            {
                using (SqlConnection conexion = AbrirConexion())
                {
                    using (SqlCommand command = new SqlCommand("AltaUsuario", conexion))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        // Asignar parámetros al procedimiento almacenado
                        command.Parameters.AddWithValue("@Username", usuario.Username);
                        command.Parameters.AddWithValue("@Password", usuario.password);
                        command.Parameters.AddWithValue("@Digito", usuario.Digito);
                        command.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                        command.Parameters.AddWithValue("@Email", usuario.Email);
                        command.Parameters.AddWithValue("@Apellidos", usuario.Apellidos);
                        command.Parameters.AddWithValue("@NumDocumento", usuario.NumDocumento);
                        command.Parameters.AddWithValue("@Telefono", usuario.Telefono);
                        command.Parameters.AddWithValue("@Celular", usuario.Celular);
                        command.ExecuteNonQuery();
                    }
                   


                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error al ejecutar el procedimiento almacenado o conectar a la base de datos.\n\n" + ex.Message);

            }finally
            {
                CerrarConexion();
            }
        }
    }
}
