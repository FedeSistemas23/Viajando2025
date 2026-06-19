using CapaSesion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_CargaComboHotel : Conexion
    {
        SqlCommand cmd = new SqlCommand();
        Conexion conexion = new Conexion();
       
        public List<Hotel> CargarComboHotelD(Destino destino, out string mensaje)
        {   
            List<Hotel> listaHoteles = new List<Hotel>();
           
            
            try
            {   
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "CargaComboHoteles";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Destino", destino);
                SqlDataReader leer = cmd.ExecuteReader();
               
                while (leer.Read())
                {
                    listaHoteles.Add(new Hotel()
                    {
                        CantidadDeHabitaciones = Convert.ToInt32(leer["CantidadDeHabitaciones"]),
                        Desayuno = Convert.ToBoolean(leer["Desayuno"]),
                        MediaPension = Convert.ToBoolean(leer["MediaPension"]),
                        PensionCompleta = Convert.ToBoolean(leer["PensionCompleta"]),
                        Single = Convert.ToInt32(leer["Single"]),
                        Doble  = Convert.ToInt32(leer["Doble"]),
                        Triple = Convert.ToInt32(leer["Triple"]),
                        Cuadruple = Convert.ToInt32(leer["Cuadruple"]),
                    });
                }  
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar SP o Conexion a la BD. \n \n" + ex.Message);
            }
            finally 
            {
                 
                cmd.Parameters.Clear();
                conexion.CerrarConexion();
            }
        return listaHoteles;
        }
    }
}
