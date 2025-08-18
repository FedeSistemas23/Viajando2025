using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaDatos.CD_Usuario;
using CapaSesion;

namespace CapaNegocio.CN_Usuario
{
   public class CN_EditarDatosUsuario : CD_EditarDatosUsuario
    {
        CD_EditarDatosUsuario usuarioCD = new CD_EditarDatosUsuario();
        public bool editarDatosUsuarioCN(CN_Nuevo_Usuario usuario)
        {
            try
            {
               return usuarioCD.EditarUsuario_CD(usuario);
            }
            catch(Exception ex) 
            {
                Console.WriteLine("ERROR AL INTENTAR EDITAR LOS DATOS DEL USUARIO_CN " + ex.Message.ToString());
                return false;
            }
        }
    }
}
