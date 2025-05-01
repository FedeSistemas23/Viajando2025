using CapaDatos;
using CapaSesion;
using System.Collections.Generic;
using System.Data;

namespace CapaNegocio
{
    public class CN_Destino
    {
        CD_Destino Destino = new CD_Destino();
        

        public void AgregarDestinoL(string nombre, string localidad, string partido, string provincia)
        {
            Destino.GuardarDestinoD(nombre, localidad, partido, provincia);
        }

        public List<CS_Destino> MostrarD()
        {
            List<CS_Destino> Destinos = new List<CS_Destino> ();
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
