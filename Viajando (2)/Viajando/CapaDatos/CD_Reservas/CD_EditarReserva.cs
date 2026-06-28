using CapaSesion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_EditarReserva : Conexion
    {
        public bool EditarReserva_CD(Reserva reserva, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection connection = AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("EditarReserva", connection))
                    {
                        cmd.Parameters.AddWithValue("@NroReserva", reserva.NroReserva);
                        cmd.Parameters.AddWithValue("@Id_pasajero", reserva.Pasajero.Id_Pasajero);
                        cmd.Parameters.AddWithValue("@Id_Paquete", reserva.Paquete.Id_Paquete);
                        cmd.Parameters.AddWithValue("@CantidadPasajeros", reserva.CantidadPasajeros);
                        cmd.Parameters.AddWithValue("@Id_Vendedor", reserva.Id_Vendedor);
                        cmd.Parameters.AddWithValue("@NombreVendedor", reserva.NombreVendedor);
                        cmd.Parameters.AddWithValue("@Destino", reserva.Destino);
                        cmd.Parameters.AddWithValue("@FechaSalida", reserva.FechaSalida);
                        cmd.Parameters.AddWithValue("@fecha", reserva.FechaReserva);
                        cmd.Parameters.AddWithValue("@fechaRegreso", reserva.FechaRegreso);
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
