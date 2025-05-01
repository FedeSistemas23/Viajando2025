using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_EliminarPaquete
    {
        CD_EliminarPaquete EliminarPaquete = new CD_EliminarPaquete();
        public void EliminarPaqueteL(int Id)
        {
            EliminarPaquete.EliminarPaqueteD(Id);
        }
    }
}
