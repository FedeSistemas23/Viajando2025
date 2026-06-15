using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaSesion;

namespace CapaDatos
{
    public class CD_CargarComboDestinos : Conexion
    {
        SqlCommand cmd = new SqlCommand();
        Conexion conexion = new Conexion();
        List<Destino> destinos = new List<Destino>();
        public List<Destino> CargarComboDestinosD()
        {
            SqlDataReader leer;
            try
            {
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "CargarComboDestinos";
                cmd.CommandType = CommandType.StoredProcedure;
                leer = cmd.ExecuteReader();
                if (leer != null )
                {
                    while ( leer.Read())
                    {
                            // Id_Destino = Convert.ToInt32(leer["Id_Destino"].ToString()),
                          
                       
                        destinos.Add((Destino)leer["Nombre"]);
                    }
                }
               
                return destinos;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar SP o Conexion a la BD. \n \n" + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }

        }
    }
}
