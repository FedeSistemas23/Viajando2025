using System;
using CapaSesion;

namespace CapaServicios.Contrasenia
{
    public class ValidarDatosPersonalesEnPassword
    {
        private void ValidarDatosPersonales(
        string password,
        Usuario usuario,
        ConfiguracionSeguridad config)
        {
            if (!config.VerificarDatosPersonales)
                return;

            string pass =
                password.ToLower();

            if (pass.Contains(usuario.Persona.Nombre.ToLower()))
            {
                throw new Exception(
                    "La contraseña no puede contener el nombre.");
            }

            if (pass.Contains(usuario.Persona.Apellido.ToLower()))
            {
                throw new Exception(
                    "La contraseña no puede contener el apellido.");
            }

            if (pass.Contains(usuario.Username.ToLower()))
            {
                throw new Exception(
                    "La contraseña no puede contener el nombre de usuario.");
            }

            if (pass.Contains(usuario.Persona.DNI))
            {
                throw new Exception(
                    "La contraseña no puede contener el DNI.");
            }
        }
    }
}
}
