using CapaDatos;
using CapaSesion;

namespace CapaNegocio
{
    public class CN_EditarBus
    {
        CD_EditarBus Bus = new CD_EditarBus();

        public void EditarBusL(Bus bus)
        {
            Bus.EditarBusD(bus);
        }
    }
}
