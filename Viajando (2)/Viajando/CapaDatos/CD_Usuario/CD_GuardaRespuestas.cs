using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaSesion;
using CapaServicios;

namespace CapaDatos
{
    public class CD_GuardaRespuestas : Conexion
    {

        //int id_usuario = CS_Usuario.Id_Usuario;

        SqlCommand cmd = new SqlCommand();
        Conexion conexion = new Conexion();
        public bool GuardarRespuestas(List<Respuestas> respuestas, out string mensaje)
        {
            mensaje = string.Empty;
            try
            {
                if (respuestas == null || respuestas.Count != 3)
                {
                    mensaje = "Se requieren exactamente 3 respuestas.";
                    return false;
                }

                for (int i = 0; i < respuestas.Count; i++)
                {
                    var respuesta = respuestas[i];
                    cmd.Connection = conexion.AbrirConexion();
                    cmd.CommandText = "GuardarRespuestas";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id_Usuario", respuesta.IdUsuario);
                    cmd.Parameters.AddWithValue("@Respuesta", respuesta.Respuesta);
                    cmd.Parameters.AddWithValue("@Id_Preg", respuesta.IdPregunta);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    conexion.CerrarConexion();
                }
                mensaje = "Respuestas guardadas correctamente.";
                return true;
            }
            catch (Exception ex)
            {
                mensaje = "Error al guardar respuestas: " + ex.Message;
                return false;
            }
        }
    }
}

