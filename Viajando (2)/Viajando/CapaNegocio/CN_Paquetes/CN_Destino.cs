using CapaDatos;
using CapaSesion;
using System.Collections.Generic;
using System.Data;

namespace CapaNegocio
{
    public class CN_Destino
    {
        CD_Destino Destino = new CD_Destino(); 
        

        public void AgregarDestinoL(Destino nuevodestino)
        {
            Destino.GuardarDestinoD(nuevodestino);
        }

        public List<Destino> MostrarD()
        {
            List<Destino> Destinos = new List<Destino> ();
            Destinos=null;
            Destinos = Destino.MostrarDestinos();
            if (Destinos != null)
            {
                return Destinos;
            }
            else
            {
                return null;
            }
           
        }
        public void EliminarDestinoL(int Id_Destino)
        {
            Destino.EliminarDestinosD(Id_Destino);
        }
       
        public void EditarDestinoL(int id_destino, string nombre, string localidad, string partido, string provincia)
        {
            Destino.EditarDestinoD(id_destino, nombre, localidad,partido, provincia );
        }
    }
}
