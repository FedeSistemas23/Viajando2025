using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaServicios;
using CapaDatos;
using CapaDatos.CD_EstadosUsuario;

namespace CapaNegocio.CN_Usuario
{
    public class CN_EstadosUsuario
    {
        CD_AgegarEstado agregarEstadoCN = new CD_AgegarEstado();
        
        public bool AgregarEStadoUsuarioCN(string nombre)
        {
            try
            {
                agregarEstadoCN.InsertarEstadoCD(nombre);
                return true;

            }
            catch (Exception e) 
            {
                    Console.WriteLine("Ocurrio un error al cargar el nuevo estado" + e.Message.ToString());
                return false;            
            }

        }


    }
}
