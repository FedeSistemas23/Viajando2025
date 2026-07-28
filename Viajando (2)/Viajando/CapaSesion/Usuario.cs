using System;
using System.Collections.Generic;


namespace CapaSesion { 
       // Esta clase es la del usuario que esta logeado en el sistema.
    public class Usuario
    {
        
        
        public int IdUsuario { get; set; }

        public int IdPersona { get; set; }

        public string Username { get; set; }

        // SHA256(Username+Password)
        public string Password { get; set; }

        public int DigitoVerificador { get; set; }

        public int Id_Familia { get; set; }

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

        public string Nombre { get; set; }

        // Relaciones

        public Persona Persona { get; set; }

        public List<HistorialPassword> HistorialPasswords { get; set; }

        public List<Respuestas> Respuestas { get; set; }

        public List<UsuarioPermiso> Permisos { get; set; }

        public List<UsuarioFamilia> Familias { get; set; }

        public List<LogIntentos> IntentosLogin { get; set; }
        public string Email { get; set; }
        public string Apellidos { get; set; }
        public string NumDocumento { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
    }
}

