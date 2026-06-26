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
        Conexion conexion = new Conexion();
        public List<Destino> CargarComboDestinosD(out string mensaje)
        {
            mensaje = string.Empty;
            var destinos = new List<Destino>();

            try
            {
                using (SqlConnection conn = conexion.AbrirConexion())
                using (SqlCommand cmd = new SqlCommand("CargarComboDestinos", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader leer = cmd.ExecuteReader())
                    {
                        while (leer.Read())
                        {
                            destinos.Add(new Destino
                            {
                                Nombre = leer["Nombre"].ToString(),
                                Id_Destino = Convert.ToInt32(leer["Id_Destino"])
                            });
                        }
                    }
                }

                return destinos;
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                return new List<Destino>();
            }
        }
    }
}
