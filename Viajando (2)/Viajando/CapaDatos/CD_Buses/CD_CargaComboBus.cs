using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Policy;
using CapaSesion;

namespace CapaDatos
{
    public class CD_CargaComboBus : Conexion
    {
        SqlCommand cmd = new SqlCommand();
        Conexion conexion = new Conexion();
        List<Bus> listaBuses = new List<Bus>();
        public List<Bus> CargadorComboBusD(Destino nombre)
        {
            SqlDataReader leer;
            try
            {
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "CargaComboBus";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Destino", nombre);
                leer = cmd.ExecuteReader();
                if (leer != null)
                {
                    while (leer.Read())
                    {
                        listaBuses.Add((Bus)leer["NombreBus"]);
                    }
                }
                return listaBuses;
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

