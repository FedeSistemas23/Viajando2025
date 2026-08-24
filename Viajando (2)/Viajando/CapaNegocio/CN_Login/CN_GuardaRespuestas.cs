using CapaDatos;
using CapaSesion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_GuardaRespuestas
    {

        public bool GuardarRespuestas(List<Respuestas> respuestas, out string mensaje)
        {
            mensaje = string.Empty;
            bool guardadoExitoso = new CD_GuardaRespuestas().GuardarRespuestas(respuestas, out mensaje);
            if (!guardadoExitoso)
            {
                mensaje = "Error al guardar las respuestas: " + mensaje;
            }
            else
            {
                mensaje = "Respuestas guardadas exitosamente.";
            }
            return guardadoExitoso;
        }
    }
}
