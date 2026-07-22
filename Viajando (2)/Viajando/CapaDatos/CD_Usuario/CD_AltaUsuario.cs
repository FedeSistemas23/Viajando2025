    using CapaSesion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_AltaUsuario : Conexion
    {
        public bool GuardarUsuarioD(Usuario usuario, out string mensaje)
        {
            mensaje = "";

            try
            {
                using (SqlConnection cn = AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_AltaUsuario", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // PERSONA
                        cmd.Parameters.AddWithValue("@Nombre", usuario.Persona.Nombre);
                        cmd.Parameters.AddWithValue("@Apellido", usuario.Persona.Apellido);
                        cmd.Parameters.AddWithValue("@FechaNacimiento", usuario.Persona.FechaNacimiento);
                        cmd.Parameters.AddWithValue("@TipoDocumento", usuario.Persona.TipoDocumento);
                        cmd.Parameters.AddWithValue("@DNI", usuario.Persona.DNI);
                        cmd.Parameters.AddWithValue("@Email", usuario.Persona.Email);
                        cmd.Parameters.AddWithValue("@Telefono", usuario.Persona.Telefono);
                        cmd.Parameters.AddWithValue("@Celular", usuario.Persona.Celular);
                        cmd.Parameters.AddWithValue("@Provincia", usuario.Persona.Provincia);
                        cmd.Parameters.AddWithValue("@Partido", usuario.Persona.Partido);
                        cmd.Parameters.AddWithValue("@Localidad", usuario.Persona.Localidad);
                        cmd.Parameters.AddWithValue("@Calle", usuario.Persona.Calle);
                        cmd.Parameters.AddWithValue("@Numero", usuario.Persona.Numero);
                        cmd.Parameters.AddWithValue("@Activo", usuario.Persona.Activo);


                        // USUARIO
                        cmd.Parameters.AddWithValue("@Username", usuario.Username);
                        cmd.Parameters.AddWithValue("@Password", usuario.Password);
                        cmd.Parameters.AddWithValue("@Digito", usuario.DigitoVerificador);
                        cmd.Parameters.AddWithValue("@Id_Familia", usuario.Id_Familia);
                        cmd.Parameters.AddWithValue("@PrimeraPassword", usuario.PrimeraPassword);
                        cmd.Parameters.AddWithValue("@DebeCambiarPassword", usuario.DebeCambiarPassword);
                        cmd.Parameters.AddWithValue("@PasswordVence", usuario.PasswordVence);
                        cmd.Parameters.AddWithValue("@DiasVencimiento", usuario.DiasVencimiento);
                        cmd.Parameters.AddWithValue("@FechaUltimoCambio", usuario.FechaUltimoCambio);
                        cmd.Parameters.AddWithValue("@UsuarioTemporal", usuario.UsuarioTemporal);
                        cmd.Parameters.AddWithValue("@FechaCaducidad", (object)usuario.FechaCaducidad ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@IntentosFallidos", usuario.IntentosFallidos);
                        cmd.Parameters.AddWithValue("@FechaIntento", usuario.FechaIntento);
                        cmd.Parameters.AddWithValue("@Bloqueado", usuario.Bloqueado);
                        cmd.Parameters.AddWithValue("@BloqueadoHasta", (object)usuario.BloqueadoHasta ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Estado", usuario.Estado);
                        

                        SqlParameter pMensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 300);
                        pMensaje.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(pMensaje);

                        cn.Open();
                        cmd.ExecuteNonQuery();

                        mensaje = pMensaje.Value.ToString();

                        return mensaje == "OK";
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                return false;
            }
        }
    }
}
