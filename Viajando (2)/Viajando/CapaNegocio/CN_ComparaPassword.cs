using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_ComparaPassword
    {
        CD_ComparaPassword comparador;

        public CN_ComparaPassword()
        {
            comparador= new CD_ComparaPassword();
        }
        public bool ComparaPass(string username, string password )
        {
            bool correcto=comparador.ComparaPassD(username, password);
            if (correcto)
            {
                return true;
            }else
            {
                return false;
            }
        }
    }
}
