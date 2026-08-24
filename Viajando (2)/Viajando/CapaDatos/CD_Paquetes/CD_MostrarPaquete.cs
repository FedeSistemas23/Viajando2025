using CapaSesion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_MostrarPaquete : Conexion
    {
        public List<Paquete> MostrarPaquetes(out string mensaje)
        {
            mensaje = string.Empty;
            List<Paquete> paquetes = new List<Paquete>();

            try
            {
                using (SqlConnection connection = AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("MostrarPaquete", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Filtros opcionales (si no los usás por ahora)
                        cmd.Parameters.AddWithValue("@IdDestino", DBNull.Value);
                        cmd.Parameters.AddWithValue("@FechaSalida", DBNull.Value);
                        cmd.Parameters.AddWithValue("@SoloDisponibles", DBNull.Value);

                        // Parámetro OUTPUT
                        SqlParameter pMensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 500);
                        pMensaje.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(pMensaje);

                        using (SqlDataReader leer = cmd.ExecuteReader())
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

                                    Disponibilidad = new Disponibilidad()
                                    {
                                        Id_Disponibilidad = Convert.ToInt32(leer["Id_Disponibilidad"]),
                                        Id_Paquete = Convert.ToInt32(leer["Id_PaqueteDisponibilidad"]),
                                        CuposTotales = Convert.ToInt32(leer["CuposTotales"]),
                                        CuposDisponibles = Convert.ToInt32(leer["Disponibilidad"])
                                    },

                                    CantidadDias = Convert.ToInt32(leer["CantidadDias"]),
                                    CantidadNoches = Convert.ToInt32(leer["CantidadNoches"]),

                                    ProveedorHotel = new Hotel()
                                    {
                                        Id_ProvedorHotel = Convert.ToInt32(leer["Id_ProveedorHotel"]),
                                        NombreDelHotel = leer["NombreDelHotel"].ToString(),
                                        Regimen = leer["Regimen"].ToString(),
                                        CantidadDeHabitaciones = Convert.ToInt32(leer["CantidadDeHab"]),
                                        HabitacionesSingle = Convert.ToInt32(leer["Singles"]),
                                        HabitacionesDoble = Convert.ToInt32(leer["Doble"]),
                                        HabitacionesTriple = Convert.ToInt32(leer["Triple"]),
                                        HabitacionesCuadruple = Convert.ToInt32(leer["Cuadruple"])
                                    },

                                    ProveedorBus = new Bus()
                                    {
                                        Id_ProvedorBus = Convert.ToInt32(leer["Id_ProveedorBus"]),
                                        TipoBus = leer["TipoBus"].ToString(),
                                        TotalAsientos = Convert.ToInt32(leer["CantidadAsientos"]),
                                        AsientosCama = Convert.ToInt32(leer["CantidadCamas"]),
                                        AsientosSemicama = Convert.ToInt32(leer["CantidadSemicamas"])
                                    },

                                    GastosAdministrativos = Convert.ToDecimal(leer["GastosAdministrativos"]),
                                    PrecioLista = Convert.ToDecimal(leer["PrecioLista"]),
                                    PrecioEfectivo = Convert.ToDecimal(leer["PrecioEfectivo"]),
                                    Coste = Convert.ToDecimal(leer["Coste"])
                                };

                                paquetes.Add(paquete);
                            }
                        }

                        // El OUTPUT se puede leer recién después de cerrar el DataReader
                        mensaje = pMensaje.Value?.ToString() ?? string.Empty;
                    }
                }

                return paquetes;
            }
            catch (Exception ex)
            {
                mensaje = "Error al cargar los paquetes.";
                throw new Exception(ex.Message);
            }
        }
    }
}
