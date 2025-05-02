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

        public CN_ValidarUsuario(string NombreUsuario)
        {
            nombreusuario = NombreUsuario;
        }

        public CN_ValidarUsuario() 
        {
            
        }
        
        
        public bool ValidarNombreUsuarioL(string username)
        {
            Username = username;
            //Password = password;
            bool existe = validarusuario.ValidarNombreUsuarioD(username);
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
