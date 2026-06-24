using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaSesion;
namespace CapaNegocio
{
    public class CN_ConfiguracionesSeguridad

    {
        public void GuardarConfiguracionSeguridad( ConfiguracionSeguridad configuracion)
        {
            // Aquí puedes implementar la lógica para guardar la configuración de seguridad
            // Por ejemplo, podrías llamar a un método de la capa de datos para almacenar la configuración en una base de datos

            new CD_ConfiguracionesSeguridad().GuardarConfiguracionesSeguridad(configuracion);
        }
    }
}