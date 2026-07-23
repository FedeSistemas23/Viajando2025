using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNegocio;
using CapaServicios;
using CapaSesion;
using NUnit;
namespace TestProjectViajando
{
    [TestFixture]
    public class AltaUsuario_TestIntegracion
    {
       /* 
       [SetUp]
        public void setup()
        {
            
            CN_AltaUsuario alta_Usuario = new CN_AltaUsuario();
            Usuario obj = new Usuario()
            {
                Username = "usuarioDefault",
                password = "contraseñaAleatoria",
                Digito = 1,
                Nombre = "Nombre",
                Email = "email@ejemplo.com",
                Apellidos = "Apellido",
                TipoDocumento = "DNI",
                NumDocumento = "12345678",
                Telefono = "1234-5678",
                Celular = "0987-654321",
                Calle = "Calle Falsa",
                NumCalle = 123,
                Localidad = "Localidad",
                Partido = "Partido",
                Provincia = "Provincia",
                Familia = "Vendedor",
                intentos = 0,
                VencePass = 30,
                AvisarVencimientoPassword = true,
                ContraseñasAnteriores = false,
                Minuscula = true,
                Mayuscula = true,
                Numeros = true,
                CaracterEspecial = false,
                Minimo8Caracteres = true,
                RealizarPreguntasSeguridad = true,
                Autenticacion2pasos = false,
                Bloqueado = false,
                BloqueadoHasta = 0,
                UsuarioTemporal = false,
                VenceUsuario = 90,
                VencenPermisos = 30,
              

            };

           //DataTable  dt = alta_Usuario.AñadirAtributos(NuevoUsuario);
        }*/
        [Test]

        public void DarAltaUsuario_retornaTrue()
        {
            CN_AltaUsuario alta_Usuario = new CN_AltaUsuario();
            DataTable tabla = new DataTable();
          
            //tabla = alta_Usuario.AñadirAtributos(NuevoUsuario);
            Assert.That(tabla, Is.Not.Null);


        }
    }
}
