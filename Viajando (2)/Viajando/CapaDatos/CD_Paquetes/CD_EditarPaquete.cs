using CapaSesion;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_EditarPaquete : Conexion
    {
        SqlCommand cmd = new SqlCommand();
        Conexion conexion = new Conexion();


        public void EditarPaqueteD(Paquete paquete)
        {
            try
            {
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "EditarPaquete";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Id_Paquete", paquete.Id_Paquete);
                cmd.Parameters.AddWithValue("@Destino", paquete.Destino);
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
                cmd.ExecuteNonQuery();
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
