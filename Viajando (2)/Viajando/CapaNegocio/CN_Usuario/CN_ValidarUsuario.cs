using CapaDatos;
using CapaSesion;
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
                int digito =Seguridad.hasheo(Username, Password);
                
                return true;
            }
            else
            {
                return false;
            }
        }

        //el sigueinte metodo validar usuario se utiliza para verificar si el usuario existe, cuando ingresa el usuario desde 
        //el formulario de preguntas de seguridad, cuando olvida su contraseña.
        public bool ValidarNombreUsuarioL(string usuario)
        {
            
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
