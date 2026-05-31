using System;

namespace CapaSesion
{
    public class UsuarioPermiso
    {
        public int IdUsuario { get; set; }

        public int IdPermiso { get; set; }

        public DateTime? FechaCaducidad { get; set; }

        public Permiso Permiso { get; set; }

    }
}