    using CapaSesion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_AltaUsuario : Conexion
    {
        public void GuardarUsuarioD(Usuario usuario)
        {
            List<Usuario> lista = new List<Usuario>();
            try
            {
                using (SqlConnection conexion = AbrirConexion())
                {
                    using (SqlCommand command = new SqlCommand("AltaUsuario", conexion))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        // Asignar parámetros al procedimiento almacenado
                        command.Parameters.AddWithValue("@Username", usuario.Username);
                        command.Parameters.AddWithValue("@Password", usuario.Password);
                        command.Parameters.AddWithValue("@Digito", usuario.DigitoVerificador);
                        command.Parameters.AddWithValue("@Nombre", usuario.Persona.Nombre);
                        command.Parameters.AddWithValue("@Email", usuario.Persona.Email);
                        command.Parameters.AddWithValue("@Apellidos", usuario.Persona.Apellido);
                        command.Parameters.AddWithValue("@NumDocumento", usuario.Persona.DNI);
                        command.Parameters.AddWithValue("@Telefono", usuario.Persona.Telefono);
                        command.Parameters.AddWithValue("@Celular", usuario.Persona.Celular);
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
