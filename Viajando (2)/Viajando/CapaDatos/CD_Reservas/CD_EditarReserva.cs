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
        public bool EditarReserva_CD(Reserva reserva)
        {
            mensaje = string.Empty;

            try
            {
                using (SqlConnection connection = AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("EditarReserva", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@NroReserva", reserva.NroReserva);
                        cmd.Parameters.AddWithValue("@Id_pasajero", reserva.Id_pasajero);
                        cmd.Parameters.AddWithValue("@Id_Paquete", reserva.Id_Paquete);
                        cmd.Parameters.AddWithValue("@CantidadPasajeros", reserva.CantidadPasajeros);
                        cmd.Parameters.AddWithValue("@Id_Vendedor", reserva.Id_Vendedor);
                        cmd.Parameters.AddWithValue("@NombreVendedor", reserva.NombreVendedor);
                        cmd.Parameters.AddWithValue("@Destino", reserva.Destino);
                        cmd.Parameters.AddWithValue("@FechaSalida", reserva.FechaSalida);
                        cmd.Parameters.AddWithValue("@fecha", reserva.FechaReserva);
                        cmd.Parameters.AddWithValue("@fechaRegreso", reserva.FechaRegreso);


                        cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;


                        using (SqlDataReader leer = cmd.ExecuteNonQuery())


                            return true;
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
