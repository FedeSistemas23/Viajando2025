using CapaNegocio;
using CapaSesion;
using Loggin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectViajando
{
    [TestFixture]
    public class EliminarReserva_Test_Integracion
    {
        CN_Reserva eliminar = new CN_Reserva();
            
        [SetUp]
        public void SetUp()
        {
            string mensaje;
            eliminar.EliminarReservaCN(1009, out mensaje);
        }

        [Test]
        public void Verifica_SiSeGuardaCorrectamenteLaReserva()
        {
            bool t = true;
            string mensaje;
            bool result = eliminar.EliminarReservaCN(1008, out mensaje);
            Assert.That(result, Is.EqualTo(t));
        }
    }
}
