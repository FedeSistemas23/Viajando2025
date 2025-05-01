using CapaDatos;
using CapaSesion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_EditarPaquetes
    {
        CD_EditarPaquete ModificarPaquete = new CD_EditarPaquete();
        public void EditarPaqueteL (CS_AtributosPaquete paquete)
        {
            ModificarPaquete.EditarPaqueteD(paquete);
        }
    }
}
