using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_BloquearUsuario
    {
        CD_BloquearUsuario BloqueadorUsuario = new CD_BloquearUsuario();

        public void BloquearUsuarioL(string usuario)
        {
            BloqueadorUsuario.BloquearUsuarioD(usuario);
        }
    }
}
