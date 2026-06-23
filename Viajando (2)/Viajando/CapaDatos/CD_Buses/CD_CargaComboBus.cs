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
        public List<Bus> CargarComboBusD(int id_destino, out string mensaje)
        {
            List<Bus> listaBuses = new List<Bus>();
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
                                    listaBuses.Add(new Bus()
                                    {
                                        TipoBus=leer["TipoBus"].ToString(),
                                        Cama=leer["Cama"].ToString(),
                                        Semicama=leer["Semicama"].ToString(),
                                        Suite=leer["Suite"].ToString(),
                                        AsientosCama=Convert.ToInt32(leer["AsientosCama"]),
                                        AsientosSemicama=Convert.ToInt32(leer["AsientosSemicama"]),
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
            return listaBuses;
        }
    }
}

