using System;
using System.Collections.Generic;


namespace CapaSesion { 
       // Esta clase es la del usuario que esta logeado en el sistema.
    public class Usuario
    {
        
        public Usuario()
        {
            HistorialPasswords = new List<HistorialPassword>();
            PreguntasSeguridad = new List<UsuarioPregunta>();
            Permisos = new List<UsuarioPermiso>();
            Familias = new List<UsuarioFamilia>();
            IntentosLogin = new List<LogIntentos>();
        }
        public int IdUsuario { get; set; }

        public int IdPersona { get; set; }

        public string Username { get; set; }

        // SHA256(Username+Password)
        public string Password { get; set; }

        public int DigitoVerificador { get; set; }

        public bool PrimeraPassword { get; set; }

        public bool DebeCambiarPassword { get; set; }

        public bool PasswordVence { get; set; }

        public int DiasVencimiento { get; set; }

        public DateTime FechaUltimoCambio { get; set; }

        public bool UsuarioTemporal { get; set; }

        public DateTime? FechaCaducidad { get; set; }

        public int IntentosFallidos { get; set; }

        public DateTime FechaIntento { get; set; }

        public bool Bloqueado { get; set; }

        public DateTime? BloqueadoHasta { get; set; }

        public bool Estado { get; set; }


        // Relaciones

        public Persona Persona { get; set; }

        public List<HistorialPassword> HistorialPasswords { get; set; }

        public List<UsuarioPregunta> PreguntasSeguridad { get; set; }

        public List<UsuarioPermiso> Permisos { get; set; }

        public List<UsuarioFamilia> Familias { get; set; }

        public List<LogIntentos> IntentosLogin { get; set; }


    }
}

