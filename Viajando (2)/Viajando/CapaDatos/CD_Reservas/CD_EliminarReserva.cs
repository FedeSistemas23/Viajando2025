using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaSesion;

namespace CapaDatos
{
    public class CD_EliminarReserva : Conexion
    {
        public bool EliminarReserva_CD(int nroreserva, out string mensaje)
        {

            bool respuesta = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection connection = AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("EliminarReserva", connection))
                    {
                        cmd.Parameters.AddWithValue("@NroReserva", nroreserva);

                        cmd.Parameters.Add("Respuesta", SqlDbType.Bit).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.ExecuteNonQuery();

                        respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
                        mensaje = cmd.Parameters["@Mensaje"].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                respuesta = false;
            }
            return respuesta;
        }
    }
}
