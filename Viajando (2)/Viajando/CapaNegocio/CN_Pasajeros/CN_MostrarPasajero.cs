using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_MostrarPasajero
    {
        CD_MostrarPasajeros MostrarPasajero= new CD_MostrarPasajeros();
        public DataTable MostrarPasajeros()
        {
            DataTable tabla = new DataTable();
            
            tabla = MostrarPasajero.Mostrar();
            if(tabla==null)
            {
                return null;
            }
            else
            {
                return tabla;
            }
            
        }
        /*public DataTable MostrarPasajeros(int Id_Pasajero)
        {
            DataTable tabla = new DataTable();
            tabla = null;
            tabla = MostrarPasajero.Mostrar(Id_Pasajero);
            return tabla;
        }*/
    }
}
