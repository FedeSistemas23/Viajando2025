using CapaSesion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Buses : Conexion
    {
        public List<Bus> MostrarBusesD()
        {
            List<Bus> lista = new List<Bus>();

            try
            {
                using (SqlConnection conexion = AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("MostrarBuses", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader leer = cmd.ExecuteReader())
                        {
                            while (leer.Read())
                            {
                                lista.Add (new Bus
                                
                                {
                                    Id_ProvedorBus = Convert.ToInt32(leer["Id_ProvedorBus"]),
                                    NombreBus = leer["NombreBus"].ToString(),
                                    TipoBus = leer["TipoBus"].ToString(),
                                    Suite = Convert.ToBoolean(leer["Suite"]),
                                    Cama = Convert.ToBoolean(leer["Cama"]),
                                    Semicama = Convert.ToBoolean(leer["Semicama"]),
                                    TotalAsientos = Convert.ToInt32(leer["Cantidad_Asientos"]),
                                    AsientosCama = Convert.ToInt32(leer["AsientosCama"]),
                                    AsientosSemicama = Convert.ToInt32(leer["AsientosSemicama"]),
                                    Calle = leer["Calle"].ToString(),
                                    Numero = Convert.ToInt32(leer["Numero"]),
                                    Localidad = leer["Localidad"].ToString(),
                                    Provincia = leer["Provincia"].ToString(),
                                    Telefono = leer["Telefono"].ToString(),
                                    Email = leer["Email"].ToString(),
                                    Destino = leer["Destino"].ToString(),
                                    NombreTitularBus = leer["NombreTitularBus"].ToString(),
                                    ApellidoTitularBus = leer["ApellidoTitularBus"].ToString(),
                                    Cuit = leer["Cuit"].ToString(),
                                    Celular = leer["Celular"].ToString(),
                                });   
                            }
                        }
                    }
                }   
            }
            catch (Exception ex)
            {
                lista = new List<Bus>();
            } 
            return lista;
        }
        public int Guardar(Bus bus, out string mensaje)
        {
            int idBus = 0;
            mensaje = string.Empty;
            try
            {
                using (SqlConnection conexion = AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("GuardarBus", conexion))
                    {

                        cmd.Parameters.AddWithValue("@NombreBus", bus.NombreBus);
                        cmd.Parameters.AddWithValue("@Destino", bus.Destino);
                        cmd.Parameters.AddWithValue("@NombreTitularBus", bus.NombreTitularBus);
                        cmd.Parameters.AddWithValue("@ApellidoTitularBus", bus.ApellidoTitularBus);
                        cmd.Parameters.AddWithValue("@Cuit", bus.Cuit);
                        cmd.Parameters.AddWithValue("@Calle", bus.Calle);
                        cmd.Parameters.AddWithValue("@Numero", bus.Numero);
                        cmd.Parameters.AddWithValue("@Localidad", bus.Localidad);
                        cmd.Parameters.AddWithValue("@Provincia", bus.Provincia);
                        cmd.Parameters.AddWithValue("@Email", bus.Email);
                        cmd.Parameters.AddWithValue("@Telefono", bus.Telefono);
                        cmd.Parameters.AddWithValue("@Celular", bus.Celular);
                        cmd.Parameters.AddWithValue("@TipoBus", bus.TipoBus);
                        cmd.Parameters.AddWithValue("@Cantidad_Asientos", bus.TotalAsientos);
                        cmd.Parameters.AddWithValue("@AsientosCamas", bus.Cama);
                        cmd.Parameters.AddWithValue("@AsientosSemicamas", bus.Semicama);

                        cmd.Parameters.Add("@Id_ProvedorBus", SqlDbType.Int).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("@mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.ExecuteNonQuery();

                        idBus = Convert.ToInt32(cmd.Parameters["@Id_ProvedorBus"].Value);
                        mensaje = cmd.Parameters["@mensaje"].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                idBus = 0;
                mensaje = ex.Message;
            }
            return idBus;
        }

        public bool Editar(Bus bus, out string mensaje)
        {
            bool resultado = false;
            mensaje = string.Empty;
            try
            {
                using (SqlConnection conexion = AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("GuardarBus", conexion))
                    {

                        cmd.Parameters.AddWithValue("@NombreBus", bus.NombreBus);
                        cmd.Parameters.AddWithValue("@Destino", bus.Destino);
                        cmd.Parameters.AddWithValue("@NombreTitularBus", bus.NombreTitularBus);
                        cmd.Parameters.AddWithValue("@ApellidoTitularBus", bus.ApellidoTitularBus);
                        cmd.Parameters.AddWithValue("@Cuit", bus.Cuit);
                        cmd.Parameters.AddWithValue("@Calle", bus.Calle);
                        cmd.Parameters.AddWithValue("@Numero", bus.Numero);
                        cmd.Parameters.AddWithValue("@Localidad", bus.Localidad);
                        cmd.Parameters.AddWithValue("@Provincia", bus.Provincia);
                        cmd.Parameters.AddWithValue("@Email", bus.Email);
                        cmd.Parameters.AddWithValue("@Telefono", bus.Telefono);
                        cmd.Parameters.AddWithValue("@Celular", bus.Celular);
                        cmd.Parameters.AddWithValue("@TipoBus", bus.TipoBus);
                        cmd.Parameters.AddWithValue("@Cantidad_Asientos", bus.TotalAsientos);
                        cmd.Parameters.AddWithValue("@AsientosCamas", bus.AsientosCama);
                        cmd.Parameters.AddWithValue("@AsientosSemicamas", bus.AsientosSemicama);

                        cmd.Parameters.Add("@resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("@mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.ExecuteNonQuery();

                        resultado = Convert.ToBoolean(cmd.Parameters["@Id_ProvedorBus"].Value);
                        mensaje = cmd.Parameters["@mensaje"].Value.ToString();
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

        public bool Eliminar(int id_provedorbus, out string mensaje)
        {
            bool resultado = false;
            mensaje = string.Empty;
            
            try
            {
                using (SqlConnection conexion = AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("EliminarBus", conexion))
                    {

                        cmd.Parameters.AddWithValue("@Id_ProvedorBus", id_provedorbus);
                        cmd.Parameters.Add("@resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("@mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.ExecuteNonQuery();

                        resultado = Convert.ToBoolean(cmd.Parameters["@Id_ProvedorBus"].Value);
                        mensaje = cmd.Parameters["@mensaje"].Value.ToString();
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
