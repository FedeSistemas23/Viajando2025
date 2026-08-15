using CapaDatos;
using CapaSesion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.CN_Buses
{
    public class Buses
    {
        private CD_Buses obj = new CD_Buses();

        public List<Bus> MostrarBusesL()
        {
            List<Bus> Buses = obj.MostrarBusesD();
            if (Buses == null)
            {
                return null;
            }
            else
            {
                return Buses;
            }
        }

        public int Guardar(Bus bus, out string mensaje)
        {
            return obj.Guardar(bus, out mensaje);
        }

        public bool Editar(Bus bus, out string mensaje)
        {
            return obj.Editar(bus, out mensaje);
        }

        public bool Eliminar(int id_provedorbus, out string mensaje)
        {
            return obj.Eliminar(id_provedorbus, out mensaje);
        }

        public List<Bus> CargaComboBusL(int id_bus, out string mensaje)
        {
            mensaje = string.Empty;

            List<Bus> Buses = new CD_CargaComboBus().CargarComboBusD(id_bus, out mensaje);

            if (Buses != null)
            {
                mensaje += "Buses cargados correctamente.";
            }
            else
            {
                mensaje += "No exiten buses en ese Destino. Debe cargarlos primero";
            }
            return Buses;
        }
        
        
        

        
        

       

        

        

    }

}

