using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_ValidarUsuario
    {
        private string username;
        private string password;
        CD_ValidarUsuario validarusuario = new CD_ValidarUsuario();

        public CN_ValidarUsuario()
        {
            
        }

        public CN_ValidarUsuario(string Username, string Pass) 
        {
            username = Username;
            password = Pass;
        }
        
        public bool ValidarUsuarioL()
        {
            bool existe = validarusuario.ValidarUsuarioD(username);
            if (existe)
            {
                                
                return true;
            }
            else 
            { 
                return false; 
            }
        }
    }
}
