using CapaDatos;
using CapaSesion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CapaNegocio
{
    public class CN_Buses
    {
        CD_Buses obj;
        List<Bus> Buses;
        public CN_Buses()
        {
            obj = new CD_Buses();
            Buses = new List<Bus> ();
        }
        
        public List<Bus> MostrarBusesL()
        {
            Buses=null;
            Buses = obj.MostrarBusesD();
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
            mensaje = string.Empty;

            if (string.IsNullOrEmpty(bus.NombreBus))
            {
                mensaje += "El nombre del bus no puede ser vacío."; 
            }
            
            if (string.IsNullOrEmpty(bus.Destino))
            {
                mensaje += "El destino del bus no puede ser vacío.";
            }
            
            if (string.IsNullOrEmpty(bus.Celular))
            {
                mensaje += "Tiene que ingresar un numero de celular correcto.";
            }
           
            if (string.IsNullOrEmpty(bus.Email))
            {
                mensaje += "Tiene que ingresar un email correcto.";
            }
            
            if (mensaje != string.Empty)
            {
                return 0;
            }else
            {
                return obj.Guardar(bus, out mensaje);
            } 
        }

        public bool Editar(Bus bus, out string mensaje)
        {
            return obj.Editar(bus, out mensaje);
        }

        public bool Eliminar(int id_provedorbus, out string mensaje)
        {
            return obj.Eliminar(id_provedorbus, out mensaje);
        }
       
    }
}
