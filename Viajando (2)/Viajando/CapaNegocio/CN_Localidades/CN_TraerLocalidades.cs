using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaSesion;

namespace CapaNegocio.CN_Localidades
{
    public class CN_TraerLocalidades
    {
        CD_TraerLocalidades localidadesCD = new CD_TraerLocalidades();
        List<CS_Localidades> listaLocalidades = new List<CS_Localidades>();

        public List<CS_Localidades> TraerLocalidadesCN()
        {
            try
            {
                listaLocalidades = localidadesCD.TraerLocalidadesCD().ToList();
                return listaLocalidades;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al traer los datos CN_TRAERLOCALIDADES: " + ex.Message);
                return listaLocalidades.ToList();
            }
        }

    }
}
