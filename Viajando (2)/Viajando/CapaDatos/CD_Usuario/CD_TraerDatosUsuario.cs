using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.Common;
using CapaSesion;


namespace CapaDatos
{
   public class CD_TraerDatosUsuario : Conexion
    {
        List<CN_Nuevo_Usuario> lista = new List<CN_Nuevo_Usuario>();

        public List<CN_Nuevo_Usuario> ObtenerUsuarios()
        {
            try
            {
                using (SqlConnection conexion = AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("SP_MostrarDatosUsuario", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataReader dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            CN_Nuevo_Usuario usuario = new CN_Nuevo_Usuario
                            {
                                //IdUsuario = Convert.ToInt32(dr["IdUsuario"]),
                                Username = dr["Username"].ToString(),
                               // password = dr["Password"].ToString(),
                                //Digito = Convert.ToInt32(dr["Digito"].ToString()),
                                Nombre = dr["Nombre"].ToString(),
                                Email = dr["Email"].ToString(),
                                Apellidos = dr["Apellidos"].ToString(),
                                NumDocumento = dr["NumDocumento"].ToString(),
                                Telefono = dr["Telefono"].ToString(),
                                Celular = dr["Celular"].ToString()
                            };

                            lista.Add(usuario);

                        }

                        return lista;
                    }

                }
            }
            catch (Exception ex)
            {
                   throw new Exception("Error al ejecutar SP o Conexion a la BD. \n\n" + ex.Message);
            }
        }
    }
}


        /*
 

    public List<Usuario> ObtenerUsuarios()
    {
        List<Usuario> lista = new List<Usuario>();

        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            SqlCommand cmd = new SqlCommand("ObtenerUsuarios", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                lista.Add(new Usuario
                {
                    IdUsuario = Convert.ToInt32(dr["IdUsuario"]),
                    Username = dr["Username"].ToString(),
                    Password = dr["Password"].ToString(),
                    Digito = dr["Digito"].ToString(),
                    Nombre = dr["Nombre"].ToString(),
                    Email = dr["Email"].ToString(),
                    Apellidos = dr["Apellidos"].ToString(),
                    NumDocumento = dr["NumDocumento"].ToString(),
                    Telefono = dr["Telefono"].ToString(),
                    Celular = dr["Celular"].ToString()
                });
            }
        }

        return lista;
    }
}

         */



