using CapaSesion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_CargaComboHotel : Conexion
    {    
        public List<Hotel> CargarComboHotelD(int id_destino, out string mensaje)
        {
            List<Hotel> listaHoteles = new List<Hotel>();
            mensaje = string.Empty; 

            try
            {
                using (SqlConnection connection = AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("CargaComboHoteles", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@Id_Destino", SqlDbType.Int).Value = id_destino;
                        cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                        using (SqlDataReader leer = cmd.ExecuteReader())
                        {
                            if (leer.HasRows)
                            {
                                while (leer.Read())
                                {
                                    listaHoteles.Add(new Hotel()
                                    {
                                        CantidadDeHabitaciones = Convert.ToInt32(leer["CantidadDeHabitaciones"]),
                                        Desayuno = Convert.ToBoolean(leer["Desayuno"]),
                                        MediaPension = Convert.ToBoolean(leer["MediaPension"]),
                                        PensionCompleta = Convert.ToBoolean(leer["PensionCompleta"]),
                                        HabitacionesSingle = Convert.ToInt32(leer["Single"]),
                                        HabitacionesDoble = Convert.ToInt32(leer["Doble"]),
                                        HabitacionesTriple = Convert.ToInt32(leer["Triple"]),
                                        HabitacionesCuadruple = Convert.ToInt32(leer["Cuadruple"]),
                                    });
                                }
                                
                                mensaje = cmd.Parameters["@Mensaje"].Value?.ToString() ?? string.Empty;
                            }
                            else
                            {
                                mensaje = cmd.Parameters["@Mensaje"].Value?.ToString() ?? string.Empty;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
            return listaHoteles;
        }
    }
}
