using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaSesion;

namespace CapaNegocio
{
    public class CN_TraerProvincias
    {
        List<CS_Provincias> listaprovincias;
        public List<CS_Provincias> traerProvinciasCN()
        {   CD_TraerProvincias traerProvCN = new CD_TraerProvincias();
            try
            {

                listaprovincias = null;
                listaprovincias = traerProvCN.TraerProvinciasCD().ToList(); ;
                if (listaprovincias == null)
                {
                    return null;
                }
                else
                {
                    return listaprovincias;
                }
               // return traerProvCN.TraerProvinciasCD();

            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR AL TRAER LISTA DE PROVINCIAS, CN_TRAER PROVINCIAS"
                                    + ex.Message.ToString());
                return listaprovincias;
            }
            
        }
    }
}
