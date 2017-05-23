using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ControladorDePedidos.WPF
{
    public static class Utilitarios
    {
        public static void EnviarEmail(string destinatario, string titulo, string mensagem)
        {
            var emailDeOrigem = "denisvieira@me.com";
            var servidorSMTP = "in-v3.mailjet.com";
            var portaSMTP = 587;
            var usuarioSMTP = "ef7a3c54fa5d5f512daface22612ff15";
            var senhaSMTP = "5a384b57553555d8135a3f9ae9c1509e";

            var smtp = new SmtpClient();
            smtp.Host = servidorSMTP;
            smtp.Port = portaSMTP;
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(usuarioSMTP, senhaSMTP);

            var msg = new MailMessage();
            msg.To.Add(destinatario);
            msg.Subject = titulo;
            msg.IsBodyHtml = true;
            msg.From = new MailAddress(emailDeOrigem);
            msg.ReplyToList.Add(emailDeOrigem);
            msg.Body = mensagem;

            smtp.Send(msg);


        }
    }
}
