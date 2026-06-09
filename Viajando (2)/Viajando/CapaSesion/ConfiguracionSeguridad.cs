using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaSesion
{
    public class ConfiguracionSeguridad
    {
        public int IdConfiguracion { get; set; }

        public int MinCaracteres { get; set; }

        public bool RequiereMay { get; set; }

        public bool RequiereMin { get; set; }

        public bool RequiereNumeros { get; set; }

        public bool RequiereEspecial { get; set; }

        public bool Usa2FA { get; set; }

        public bool NoRepetirPassword { get; set; }

        public bool VerificarDatosPersonales { get; set; }

        public bool DesbloqueoAutomatico { get; set; }

        public int TiempoDesbloqueoHoras { get; set; }

        public int TiempoDesbloqueoDias { get; set; }

        public bool UsaPreguntasSeguridad { get; set; }

        public bool AvisarVencimiento { get; set; }

        public int DiasAviso { get; set; }

        public bool UsuarioBloqueado { get; set; } 

        public int IntentosFallidos { get; set; }
    }
 


}

