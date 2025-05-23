﻿using CapaSesion;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_EditarPaquete : Conexion
    {
        SqlCommand cmd = new SqlCommand();
        Conexion conexion = new Conexion();


        public void EditarPaqueteD(CS_AtributosPaquete paquete)
        {
            try
            {
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "EditarPaquete";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Id_Paquete", paquete.Id_Paquete);
                cmd.Parameters.AddWithValue("@Destino", paquete.Destino);
                cmd.Parameters.AddWithValue("@Disponibilidad", paquete.Disponibilidad);
                cmd.Parameters.AddWithValue("@Single", paquete.Single);
                cmd.Parameters.AddWithValue("@Doble", paquete.Doble);
                cmd.Parameters.AddWithValue("@Triple", paquete.Triple);
                cmd.Parameters.AddWithValue("@Cuadruple", paquete.Cuadruple);
                cmd.Parameters.AddWithValue("@Regimen", paquete.Regimen);
                cmd.Parameters.AddWithValue("@FechaRegreso", paquete.FechaRegreso);
                cmd.Parameters.AddWithValue("@CantidadDias", paquete.CantidadDias);
                cmd.Parameters.AddWithValue("@CantidadNoches", paquete.CantidadNoches);
                cmd.Parameters.AddWithValue("@ProveedorHotel", paquete.ProveedorHotel);
                cmd.Parameters.AddWithValue("@ProveedorBus", paquete.ProveedorBus);
                cmd.Parameters.AddWithValue("@CantidadAsientos", paquete.CantidadAsientos);
                cmd.Parameters.AddWithValue("@CantidadCamas", paquete.AsientosCama);
                cmd.Parameters.AddWithValue("@CantidadSemicamas", paquete.AsientosSemicama);
                cmd.Parameters.AddWithValue("@GastosAdministrativos", paquete.GastosAdministrativos);
                cmd.Parameters.AddWithValue("@PrecioEfectivo", paquete.PrecioEfectivo);
                cmd.Parameters.AddWithValue("@PrecioLista", paquete.PrecioLista);
                cmd.Parameters.AddWithValue("@CantidadDeHab", paquete.CantidadDeHab);
                cmd.Parameters.AddWithValue("@Coste", paquete.Coste);
                cmd.Parameters.AddWithValue("@FechaSalida", paquete.FechaSalida);
                cmd.Parameters.AddWithValue("@TipoBus", paquete.TipoBus);
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
