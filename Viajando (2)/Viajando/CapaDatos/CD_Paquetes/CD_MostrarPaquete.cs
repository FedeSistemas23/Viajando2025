using CapaSesion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_MostrarPaquete : Conexion
    {
        public List<Paquete> MostrarPaquetes()
        {
            List<Paquete> Paquetes = new List<Paquete>();

            try
            {
                using (SqlConnection connection = AbrirConexion()) // Asegura que la conexión se cierra correctamente
                {
                    using (SqlCommand cmd = new SqlCommand("MostrarPaquete", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader leer = cmd.ExecuteReader())
                        {
                            if (leer.HasRows)
                            {
                                while (leer.Read())
                                {
                                    Paquete paquete = new Paquete
                                    {
                                        Id_Paquete = Convert.ToInt32(leer["Id_Paquete"]),
                                        Destino = new Destino()
                                        {
                                            Id_Destino = Convert.ToInt32(leer["Id_Destino"]),
                                            Nombre = leer["NombreDestino"].ToString()
                                        },
                                        FechaSalida = Convert.ToDateTime(leer["FechaSalida"]),
                                        FechaRegreso = Convert.ToDateTime(leer["FechaRegreso"]),
                                        Disponibilidad = new Disponibilidad
                                        {
                                            Id_Disponibilidad = leer["Id_Disponibilidad"] != DBNull.Value ? Convert.ToInt32(leer["Id_Disponibilidad"]) : 0,
                                            Id_Paquete = leer["Id_Paquete"] != DBNull.Value ? Convert.ToInt32(leer["Id_Paquete"]) : 0,
                                            CuposTotales = leer["CuposTotales"] != DBNull.Value ? Convert.ToInt32(leer["CuposTotales"]) : 0,
                                            CuposDisponibles = leer["Disponibilidad"] != DBNull.Value ? Convert.ToInt32(leer["Disponibilidad"]) : 0
                                        },
                                        CantidadDias = Convert.ToInt32(leer["CantidadDias"]),
                                        CantidadNoches = Convert.ToInt32(leer["CantidadNoches"]),
                                        ProveedorHotel = new Hotel()
                                        {
                                            Id_ProvedorHotel = Convert.ToInt32(leer["Id_ProveedorHotel"]),
                                            NombreDelHotel = leer["NombreDelHotel"].ToString(),
                                            Regimen = leer["Regimen"].ToString(),
                                            CantidadDeHabitaciones = Convert.ToInt32(leer["CantidadDeHab"]),
                                            HabitacionesSingle = Convert.ToInt32(leer["Sigles"]),
                                            HabitacionesDoble = Convert.ToInt32(leer["Doble"]),
                                            HabitacionesTriple = Convert.ToInt32(leer["Triple"]),
                                            HabitacionesCuadruple = Convert.ToInt32(leer["Triple"]),
                                        },
                                        ProveedorBus = new Bus()
                                        {
                                            Id_ProvedorBus = Convert.ToInt32(leer["Id_ProveedorBus"]),
                                            TipoBus = leer["TipoBus"].ToString(),
                                            CantidadDeAsientos = Convert.ToInt32(leer["CantidadAsientos"]),
                                            AsientosCama = Convert.ToInt32(leer["CantidadCamas"]),
                                            AsientosSemicama = Convert.ToInt32(leer["CantidadSemicamas"]),
                                        },
                                        GastosAdministrativos = Convert.ToDecimal(leer["GastosAdministrativos"]),
                                        PrecioLista = Convert.ToDecimal(leer["PrecioLista"]),
                                        PrecioEfectivo = Convert.ToDecimal(leer["PrecioEfectivo"]),
                                        Coste = Convert.ToDecimal(leer["Coste"]),
                                    };

                                    // Añadir el objeto paquete a la lista de paquetes
                                    Paquetes.Add(paquete);
                                }
                            }
                            else
                            {
                                return null; // Si no hay filas, devolver null o manejar el caso según sea necesario
                            }
                        }
                    }
                }
                return Paquetes;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar SP o Conexion a la BD. \n\n" + ex.Message);
            }
        }
    }
}
