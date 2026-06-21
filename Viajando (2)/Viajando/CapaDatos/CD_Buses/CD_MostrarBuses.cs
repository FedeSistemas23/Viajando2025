using CapaSesion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_MostrarBuses : Conexion
    {
        public List<Bus> MostrarBusesD()
        {
            List<Bus> buses = new List<Bus>();

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
                                Bus bus = new Bus
                                {
                                    Id_ProvedorBus = Convert.ToInt32(leer["Id_ProvedorBus"]),
                                    NombreBus = leer["NombreBus"].ToString(),
                                    TipoBus = leer["TipoBus"].ToString(),
                                    CantidadDeAsientos = Convert.ToInt32(leer["Cantidad_Asientos"]),
                                    Cama = leer["AsientosCamas"].ToString(),
                                    Semicama = leer["AsientosSemicamas"].ToString(),
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
                                };
                                buses.Add(bus);
                            }
                        }
                    }
                }

                return buses;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar el procedimiento almacenado o conectar a la base de datos.\n\n" + ex.Message);
            }
            finally
            {
                CerrarConexion();

            }
        }
    }
}
