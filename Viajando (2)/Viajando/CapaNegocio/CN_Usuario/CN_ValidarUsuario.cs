using CapaDatos;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_ValidarUsuario
    {
        private string nombreusuario;
        string Username;
        private string Password;
        CD_ValidarUsuario validarusuario = new CD_ValidarUsuario();

        public CN_ValidarUsuario()
        {        
        }

        public CN_ValidarUsuario(string username, string pass) 
        {
            Username= username;
            Password= pass;
        }
        
        
        public bool ValidarNombreUsuarioL()
        {            
            //Password = password;
            bool existe = validarusuario.ValidarNombreUsuarioD(Username);
            if (existe)
            {

                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ValidarNombreUsuarioL(string usuario)
        {
            //Password = password;
            bool existe = validarusuario.ValidarNombreUsuarioD(usuario);
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
