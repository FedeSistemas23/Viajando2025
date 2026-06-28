using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaSesion;
using System.Data;
using System.Data.SqlClient;
using System.Security.Policy;

namespace CapaDatos
{
  public class CD_GuardarReserva : Conexion
    {
        SqlCommand cmd = new SqlCommand();  
        Conexion conexion = new Conexion();

        public bool GuardarReserva_CD(Reserva reserva)
        {
            
            Reserva CD_reserva = new Reserva();

            cmd.Connection = AbrirConexion();
            cmd.CommandText = "GuardarReservas";
            cmd.CommandType = CommandType.StoredProcedure;
           
            cmd.Parameters.AddWithValue("@Id_Paquete", reserva.Id_Paquete);
            
            cmd.Parameters.AddWithValue("@CantidadPasajeros", reserva.CantidadPasajeros);
            cmd.Parameters.AddWithValue("@Id_Vendedor", reserva.Id_Vendedor);

           
            cmd.Parameters.AddWithValue("@NombreVendedor", reserva.NombreVendedor);
            cmd.Parameters.AddWithValue("@Destino", reserva.Destino);
            cmd.Parameters.AddWithValue("@FechaSalida", reserva.FechaSalida);
            cmd.Parameters.AddWithValue("@fecha", reserva.FechaReserva);
            cmd.Parameters.AddWithValue("@FechaRegreso", reserva.FechaRegreso);

            
         
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            conexion.CerrarConexion();

            return true;
        }
    }
}
