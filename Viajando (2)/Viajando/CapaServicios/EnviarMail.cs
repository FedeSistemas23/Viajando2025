using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CapaServicios
{
    public static class EnviarMail
    {
        public static void sendMail(string to, string asunto, string body)
        {
            string from = "castellanoporto@Gmail.com"; //correo de la empresa
            string displayName = "Recuperacion de Cuenta"; //Asunto del mensaje
            try
            {
                MailMessage mail = new MailMessage
                {
                    From = new MailAddress(from, displayName)
                };
                mail.To.Add(to);

                mail.Subject = asunto;
                mail.Body = body;
                mail.IsBodyHtml = true;

                SmtpClient client = new SmtpClient("smtp.gmail.com", 587)//Aquí debes sustituir tu servidor SMTP y el puerto
                {
                    Credentials = new NetworkCredential(from, "urro zwpv jykz tszs"), //correo , contraseña de la cuenta de la empresa
                    EnableSsl = true//En caso de que tu servidor de correo no utilice cifrado SSL,poner en false
                };
                client.Send(mail);
            }
            catch (SmtpException smtpEx)
            {
                // MueSTRÁ EL MENSAJE REAL DEL ERROR SMTP
                throw new Exception("Error SMTP: " + smtpEx.Message + "\n" + smtpEx.InnerException?.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Error general al enviar correo: " + ex.Message);
            }
  
        }
    }
}

