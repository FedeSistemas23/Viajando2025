using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_EditarPassword : Conexion
    {
        SqlCommand cmd = new SqlCommand();
        Conexion conexion = new Conexion();
        public bool EditarPassword(string pass, int username, out string mensaje)
        {
            mensaje = string.Empty;
            try
            {
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "EditarPassword";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Password", pass);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.ExecuteNonQuery();                
            }
            catch  (Exception ex)          
            {
                return false;
                throw new Exception("Error al ejecutar SP o Conexion a la BD. \n \n" + ex.Message);
                
            }
            finally
            {
                cmd.Parameters.Clear();
                conexion.CerrarConexion();
            }
            return true;
        }
        
    }
}
