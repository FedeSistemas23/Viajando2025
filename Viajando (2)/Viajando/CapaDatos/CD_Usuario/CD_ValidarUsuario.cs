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

        public bool Login(Usuario usuario, out string mensaje)
        {
            bool resultado = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection cn = AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("SP_LoginUsuario", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Username", usuario.Username);
                        cmd.Parameters.AddWithValue("@PasswordHash", usuario.Password);
                        cmd.Parameters.AddWithValue("@Digito", usuario.DigitoVerificador);

                        cmd.Parameters.Add("@IdUsuario", SqlDbType.Int).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("@IdPersona", SqlDbType.Int).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("@IdFamilia", SqlDbType.Int).Direction = ParameterDirection.Output;

                        cmd.Parameters.Add("@DebeCambiarPassword", SqlDbType.Bit).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("@PasswordVencida", SqlDbType.Bit).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("@UsuarioTemporal", SqlDbType.Bit).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("@PrimerIngreso", SqlDbType.Bit).Direction = ParameterDirection.Output;

                        cmd.Parameters.Add("@LoginCorrecto", SqlDbType.Bit).Direction = ParameterDirection.Output;

                        cmd.Parameters.Add("@Mensaje", SqlDbType.NVarChar, 300).Direction = ParameterDirection.Output;

                        cn.Open();

                        cmd.ExecuteNonQuery();

                        mensaje = cmd.Parameters["@Mensaje"].Value?.ToString() ?? "";

                        resultado = Convert.ToBoolean(cmd.Parameters["@LoginCorrecto"].Value);

                        if (resultado)
                        {
                            usuario.IdUsuario = Convert.ToInt32(cmd.Parameters["@IdUsuario"].Value);
                            usuario.IdPersona = Convert.ToInt32(cmd.Parameters["@IdPersona"].Value);

                            if (cmd.Parameters["@IdFamilia"].Value != DBNull.Value)
                                usuario.Id_Familia = Convert.ToInt32(cmd.Parameters["@IdFamilia"].Value);

                            usuario.DebeCambiarPassword = Convert.ToBoolean(cmd.Parameters["@DebeCambiarPassword"].Value);
                            usuario.PasswordVence = Convert.ToBoolean(cmd.Parameters["@PasswordVencida"].Value);
                            usuario.UsuarioTemporal = Convert.ToBoolean(cmd.Parameters["@UsuarioTemporal"].Value);
                            usuario.PrimeraPassword = Convert.ToBoolean(cmd.Parameters["@PrimerIngreso"].Value);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                resultado = false;
                mensaje = ex.Message;
            }

            return resultado;
        }
    }
}

