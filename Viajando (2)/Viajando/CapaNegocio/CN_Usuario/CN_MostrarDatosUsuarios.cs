using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaSesion;

namespace CapaNegocio.CN_Usuario
{
  public class CN_MostrarDatosUsuario
    {
        CD_TraerDatosUsuario cdUsuario;
        List<CapaSesion.CN_Nuevo_Usuario> listaUsuarios;

        public CN_MostrarDatosUsuario()
        {
            listaUsuarios = new List<CapaSesion.CN_Nuevo_Usuario>();
            cdUsuario = new CD_TraerDatosUsuario();
        }

      

        public  List<CapaSesion.CN_Nuevo_Usuario> MostrarDatosDGV()
        {
            listaUsuarios = null;
            listaUsuarios = cdUsuario.ObtenerUsuarios();

            if (listaUsuarios != null)
            {
                return listaUsuarios;
            }
            else
            {
                return null;
            }

           
        }
        

    }
}
