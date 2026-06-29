using CapaSesion;
using System;
using System.Collections.Specialized;
using System.Data;
using System.Data.SqlClient;
using System.Security.Policy;

namespace CapaDatos
{
    public class CD_Reserva : Conexion
    {
        SqlCommand cmd = new SqlCommand();
        Conexion conexion = new Conexion();


        public DataTable MostrarReservaDgv_CD()
        {
            SqlDataReader leer;
            try
            {
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "MostrarReservaDataGrid";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                // cmd.Parameters.AddWithValue("@NroReserva",NumReserva);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                //leer = cmd.ExecuteReader();
                da.Fill(tabla);

                return tabla;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar SP o Conexion a la BD. \n \n" + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }

        }
        public int GuardarReserva(Reserva reserva, out string mensaje)
        {
            string mensaje = string.Empty;

            Reserva CD_reserva = new Reserva();

            cmd.Connection = AbrirConexion();
            cmd.CommandText = "GuardarReservas";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id_Paquete", reserva.Id_Paquete);

            cmd.Parameters.AddWithValue("@CantidadPasajeros", reserva.CantidadPasajeros);
            cmd.Parameters.AddWithValue("@Id_Vendedor", reserva.Id_Vendedor);


            cmd.Parameters.AddWithValue("@NombreVendedor", reserva.NombreVendedor);
            cmd.Parameters.AddWithValue("@Destino", reserva.Destino);
            cmd.Parameters.AddWithValue("@FechaSalida", reserva.FechaSalida);
            cmd.Parameters.AddWithValue("@fecha", reserva.FechaReserva);
            cmd.Parameters.AddWithValue("@FechaRegreso", reserva.FechaRegreso);



            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            conexion.CerrarConexion();

            return true;
        }
        
        
        public bool EliminarReserva(int nroreserva, out string mensaje)
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

