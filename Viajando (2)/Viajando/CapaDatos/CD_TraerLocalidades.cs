using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using CapaServicios;
using CapaSesion;

namespace CapaDatos
{
    public class CD_TraerLocalidades : Conexion
    {
        public List<CS_Localidades> TraerLocalidadesCD()
        {
            List<CS_Localidades> listaLocalidades = new List<CS_Localidades>();


                using (SqlConnection conn = AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_TraerLocalidades", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        
                        using (SqlDataReader dr = cmd.ExecuteReader()) {

                            try
                            {
                                while (dr.Read())
                                {
                                    CS_Localidades localidad = new CS_Localidades
                                    {
                                        Id_Localidad = Convert.ToInt32(dr["Id_Localidad"]),
                                        Localidad = dr["Localidad"].ToString(),
                                        Id_Partido = Convert.ToInt32(dr["Id_Partido"])
                                    };

                                    listaLocalidades.Add(localidad);
                                }
                                return listaLocalidades;
                            }
                            catch (Exception ex)
                            {

                                Console.WriteLine(ex.ToString() + "ERROR AL TRAER LOCALIDADES CAPA DATOS");
                                return listaLocalidades;
                            }
                        }
                    }
                }
           
            
        }
     
    } 
}
