
using CapaDatos;
using CapaSesion;

namespace CapaNegocio
{
    // Esta clase agrega en una lista, los datos provenientes del formulario de Ingresar Paquete
    // y luego los envia a la capa de datos para guardarlos en la base de datos
    public class CN_GuardarPaquete
    {
        public int Id { get; set; }
        
        private CD_GuardarPaquete NuevoPaquete;
        public CN_GuardarPaquete()
        {
            NuevoPaquete = new CD_GuardarPaquete();
        }

        public  int GuardarPaqueteL(CS_AtributosPaquete paquete)
        {           
            Id = NuevoPaquete.GuardarPaqueteD(paquete);
            return Id;
            
        }
        public void VerificarNuevoPaquete (int id)
        {
            CS_AtributosPaquete NewPaquete = NuevoPaquete.VerificarNuevoPaqueteD(id);
        }
    }
}
