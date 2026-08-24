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
        public List<Usuario> ObtenerUsuarios()
        { 
            List<Usuario> lista = new List<Usuario>();

            try
            {
                using (SqlConnection conexion = AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("SP_MostrarDatosUsuario", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure; 
                        if (conexion.State == ConnectionState.Closed) conexion.Open();

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {   
                                Persona obj = new Persona
                                {
                                    Nombre = dr["Nombre"] != DBNull.Value ? dr["Nombre"].ToString() : string.Empty,
                                    Email = dr["Email"] != DBNull.Value ? dr["Email"].ToString() : string.Empty,
                                    Apellido = dr["Apellidos"] != DBNull.Value ? dr["Apellidos"].ToString() : string.Empty,
                                    DNI = dr["DNI"] != DBNull.Value ? dr["DNI"].ToString() : string.Empty,
                                    Telefono = dr["Telefono"] != DBNull.Value ? dr["Telefono"].ToString() : string.Empty,
                                    Celular = dr["Celular"] != DBNull.Value ? dr["Celular"].ToString() : string.Empty,   
                                };

                                Usuario usuario = new Usuario
                                {
                                    IdUsuario = Convert.ToInt32(dr["IdUsuario"]),
                                    Username = dr["Username"].ToString(),
                                    Password = dr["Password"].ToString(),
                                    Persona = obj,                                     
                                };

                                lista.Add(usuario);
                            }
                        } 
                    }
                } 
                return lista;
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



