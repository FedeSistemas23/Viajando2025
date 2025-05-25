using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaSesion;

namespace CapaDatos.CD_EstadosUsuario
{
    public class CD_AgegarEstado: Conexion
    {
        public bool InsertarEstadoCD(string nombre)
        {
            List<CS_EstadosUsuario> listaEstadosUsario = new List<CS_EstadosUsuario>();

            try
            {
                using (SqlConnection conexion = AbrirConexion())
                {

                    using (SqlCommand cmd = new SqlCommand("sp_GuardarEstadoUsuario", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR CD_AgregarEstado : Al insertar un nuevo estado" + ex.ToString());
                return false;
            }

        }

    }
}
