using CapaSesion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;

namespace CapaNegocio.CN_Password
{
    public class CN_Password
    {
        public bool Editar(string password, int usuario, out string mensaje)
        {
            mensaje = string.Empty;
            try
            {
                CD_EditarPassword objPassword = new CD_EditarPassword();
                return objPassword.EditarPassword(password, usuario, out mensaje);
            }
            catch (Exception ex)
            {
                mensaje = "Error al editar la contraseña: " + ex.Message;
                return false;
            }
        }
    }
}
