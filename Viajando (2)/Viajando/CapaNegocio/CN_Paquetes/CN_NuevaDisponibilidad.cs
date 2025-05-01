using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_NuevaDisponibilidad
    {
        CD_NuevaDisponiblidad newDispo = new CD_NuevaDisponiblidad();
        public void CambiaDisponibilidadN(int id, int nuevaDispo)
        {
            newDispo.CambiarDispoD(id, nuevaDispo);
        }
    }
}
