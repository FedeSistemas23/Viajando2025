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
        private DataTable tabla;

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
        public bool GuardarReserva(Reserva reserva, out string mensaje)
        {
            mensaje = "";
            int nroReserva = 0;

            using (SqlConnection cn = AbrirConexion())
            {
                cn.Open();
                SqlTransaction tr = cn.BeginTransaction();

                try
                {
                    // 1. CREAR RESERVA
                    SqlCommand cmdReserva = new SqlCommand("SP_CrearReserva", cn, tr);
                    cmdReserva.CommandType = CommandType.StoredProcedure;

                    cmdReserva.Parameters.AddWithValue("@Fecha", reserva.FechaReserva);
                    cmdReserva.Parameters.AddWithValue("@FechaSalida", reserva.FechaSalida);
                    cmdReserva.Parameters.AddWithValue("@FechaRegreso", reserva.FechaRegreso);
                    cmdReserva.Parameters.AddWithValue("@Id_Vendedor", reserva.Id_Vendedor);
                    cmdReserva.Parameters.AddWithValue("@Id_Paquete", reserva.Id_Paquete);
                    cmdReserva.Parameters.AddWithValue("@NombreTitular", reserva.NombreTitular);
                    cmdReserva.Parameters.AddWithValue("@ApellidoTitular", reserva.ApellidoTitular);
                    cmdReserva.Parameters.AddWithValue("@Cotizar", reserva.Cotizar);
                    cmdReserva.Parameters.AddWithValue("@Observacion", reserva.Observacion);

                    nroReserva = Convert.ToInt32(cmdReserva.ExecuteScalar());

                    // 2. PASAJEROS
                    foreach (var p in reserva.Pasajeros)
                    {
                        SqlCommand cmd = new SqlCommand("SP_AgregarPasajeroReserva", cn, tr);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@NroReserva", nroReserva);
                        cmd.Parameters.AddWithValue("@Id_Pasajero", p.IdPasajero);
                        cmd.Parameters.AddWithValue("@EsTitular", p.EsTitular);
                        cmd.Parameters.AddWithValue("@EsMenor", p.EsMenor);

                        cmd.ExecuteNonQuery();
                    }

                    // 3. HABITACIONES
                    foreach (var h in reserva.Habitaciones)
                    {
                        SqlCommand cmd = new SqlCommand("SP_AgregarHabitacionReserva", cn, tr);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@NroReserva", nroReserva);
                        cmd.Parameters.AddWithValue("@Id_TipoHabitacion", h.IdTipoHabitacion);
                        cmd.Parameters.AddWithValue("@Cantidad", h.Cantidad);

                        cmd.ExecuteNonQuery();
                    }

                    // 4. ASIENTOS
                    foreach (var a in reserva.Asientos)
                    {
                        SqlCommand cmd = new SqlCommand("SP_AgregarAsientoReserva", cn, tr);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@NroReserva", nroReserva);
                        cmd.Parameters.AddWithValue("@Id_TipoAsiento", a.IdTipoAsiento);
                        cmd.Parameters.AddWithValue("@Cantidad", a.Cantidad);

                        cmd.ExecuteNonQuery();
                    }

                    // 5. PAGOS (SEÑA + OTROS PAGOS)
                    foreach (var pago in reserva.Pagos)
                    {
                        SqlCommand cmd = new SqlCommand("SP_AgregarPago", cn, tr);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@NroReserva", nroReserva);
                        cmd.Parameters.AddWithValue("@FechaPago", pago.FechaPago);
                        cmd.Parameters.AddWithValue("@Importe", pago.Importe);
                        cmd.Parameters.AddWithValue("@IdMedioPago", pago.IdMedioPago);
                        cmd.Parameters.AddWithValue("@EsSena", pago.EsSena);
                        cmd.Parameters.AddWithValue("@Observacion", pago.Observacion);

                        cmd.ExecuteNonQuery();
                    }

                    // 6. CONFIRMAR TODO
                    tr.Commit();

                    mensaje = "Reserva guardada correctamente";
                    return true;
                }
                catch (Exception ex)
                {
                    tr.Rollback();
                    mensaje = ex.Message;
                    return false;
                }
            }
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

