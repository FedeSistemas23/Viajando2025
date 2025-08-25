using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaSesion;

namespace CapaDatos.CD_Usuario
{
    public class CD_EditarDatosUsuario : Conexion
    {

        public bool EditarUsuario_CD(CN_Nuevo_Usuario usuario)
        {
            using (SqlConnection conn = AbrirConexion())
            {
                using (SqlCommand cmd = new SqlCommand("sp_EditarDatosUsuario", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                   
                    try
                    {
                        cmd.Parameters.AddWithValue("@Id_Usuario", usuario.Id_Usuario);
                        cmd.Parameters.AddWithValue("@Username", usuario.Username);
                        cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                        cmd.Parameters.AddWithValue("@Apellidos", usuario.Apellidos);
                        cmd.Parameters.AddWithValue("@Email", usuario.Email);
                        cmd.Parameters.AddWithValue("@Telefono", usuario.Telefono);
                        cmd.Parameters.AddWithValue("@Celular", usuario.Celular);
                        return true;
                        
                    }
                    catch (Exception ex)
                    {
                        return false;

                        throw new Exception("Error al ejecutar SP o Conexion a la BD. \n \n" + ex.Message);
                    }
                    finally
                    {
                        cmd.Parameters.Clear();
                       // conexion.CerrarConexion();
                    }
                }


            }
          
        }
    }
}
