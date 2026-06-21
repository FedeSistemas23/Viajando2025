using CapaSesion;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;


namespace CapaDatos
{
    public class CD_GuardarPaquete : Conexion
    {
        int idNuevoPaquete = 0;
        Conexion conexion = new Conexion();
        SqlCommand cmd = new SqlCommand();

        public int GuardarPaqueteD(Paquete paquete, out string mensaje)
        {
            try
            {
                cmd.CommandText = "GuardarPaquete";
                cmd.CommandType = CommandType.StoredProcedure;

                // Parámetros de entrada
                cmd.Parameters.AddWithValue("@Destino", paquete.Destino.Nombre);
                cmd.Parameters.AddWithValue("@Disponibilidad", paquete.Disponibilidad);
                cmd.Parameters.AddWithValue("@FechaRegreso", paquete.FechaRegreso);
                cmd.Parameters.AddWithValue("@CantidadDias", paquete.CantidadDias);
                cmd.Parameters.AddWithValue("@CantidadNoches", paquete.CantidadNoches);
                cmd.Parameters.AddWithValue("@ProveedorHotel", paquete.ProveedorHotel);
                cmd.Parameters.AddWithValue("@ProveedorBus", paquete.ProveedorBus);
                cmd.Parameters.AddWithValue("@GastosAdministrativos", paquete.GastosAdministrativos);
                cmd.Parameters.AddWithValue("@PrecioEfectivo", paquete.PrecioEfectivo);
                cmd.Parameters.AddWithValue("@PrecioLista", paquete.PrecioLista);
                cmd.Parameters.AddWithValue("@Coste", paquete.Coste);
                cmd.Parameters.AddWithValue("@FechaSalida", paquete.FechaSalida);
                cmd.Parameters.Add("@IdnuevoPaquete", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;


                cmd.Connection = conexion.AbrirConexion();
                cmd.ExecuteNonQuery();

                // Obtener los valores de salida
                idNuevoPaquete = Convert.ToInt32(cmd.Parameters["@IdNuevoPaquete"].Value);
                mensaje = cmd.Parameters["@Mensaje"].Value.ToString();


            }
            catch (Exception ex)
            {
                idNuevoPaquete = 0;
                mensaje = ex.Message;
            }
            finally
            {
                cmd.Parameters.Clear();
                conexion.CerrarConexion();
            }
            return idNuevoPaquete;
        }

        /*public Paquete VerificarNuevoPaqueteD(int id)
        {
            /*Paquete nuevopaquete = new Paquete();
            Conexion conexion = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "MostrarNuevoPaquete";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id_Paquete", id);
            //Id_Paquete= Convert.ToInt32(cmd.ExecuteScalar());
            SqlDataReader leer = cmd.ExecuteReader();
            if (leer.HasRows)
            {
                while (leer.Read())
                {
                    nuevopaquete = new Paquete()
                    {
                        Destino = leer["Destino"].ToString(),
                        Disponibilidad = Convert.ToInt32(leer["Disponibilidad"]),
                        Single = Convert.ToInt32(leer["Single"]),
                        Doble = Convert.ToInt32(leer["Doble"]),
                        Triple = Convert.ToInt32(leer["Triple"]),
                        Cuadruple = Convert.ToInt32(leer["Cuadruple"]),
                        Regimen = leer["Regimen"].ToString(),
                        FechaRegreso = Convert.ToDateTime(leer["FechaRegreso"]),
                        CantidadDias = Convert.ToInt32(leer["CantidadDias"]),
                        CantidadNoches = Convert.ToInt32(leer["CantidadNoches"]),
                        ProveedorHotel = leer["ProveedorHotel"].ToString(),
                        ProveedorBus = leer["ProveedorBus"].ToString(),
                        CantidadAsientos = Convert.ToInt32(leer["CantidadAsientos"]),
                        AsientosCama = Convert.ToInt32(leer["CantidadCamas"]),
                        AsientosSemicama = Convert.ToInt32(leer["CantidadSemicamas"]),
                        GastosAdministrativos = Convert.ToDecimal(leer["GastosAdministrativos"]),
                        PrecioEfectivo = Convert.ToDecimal(leer["PrecioEfectivo"]),
                        PrecioLista = Convert.ToDecimal(leer["PrecioLista"]),
                        CantidadDeHab = Convert.ToInt32(leer["CantidadDeHab"]),
                        Coste = Convert.ToDecimal(leer["Coste"]),
                        FechaSalida = Convert.ToDateTime(leer["FechaSalida"]),
                        TipoBus = leer["TipoBus"].ToString(),
                    };
                    return nuevopaquete;
                }
            }
            return nuevopaquete;
        }
        }*/
    }
}


