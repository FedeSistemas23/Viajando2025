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
        List<Hotel> listaHoteles = new List<Hotel>();
        public List<Hotel> CargarComboHotelD(Destino destino)
        {
            SqlDataReader leer;
            try
            {
                listaHoteles.Clear();
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "CargaComboHoteles";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Destino", destino);
                leer = cmd.ExecuteReader();
                if (leer != null)
                {
                    while (leer.Read())
                    {
                        listaHoteles.Add((Hotel)leer["Nombre_Hotel"]);
                    }
                }
                else
                {
                    return null;
                }
                return listaHoteles;
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
        }
    }
}
