using System.Net;
using System.Net.Mail;

namespace MyDemoApp.Helper
{
    public class EmailSender
    {
        public static bool Send(string to, string subject, string message)
        {
            MailMessage msg = new MailMessage();
            SmtpClient client = new SmtpClient();

            //Adding information to MailMessage Object
            msg.From = new MailAddress("iscdhn2022@gmail.com");
            msg.To.Add(to);
            msg.Subject = subject;
            msg.Body = message;
            msg.IsBodyHtml = true;

            //Adding SMTP object information
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential("iscdhn2022@gmail.com", "ppxo mxhw docb woyh");
            client.DeliveryMethod = SmtpDeliveryMethod.Network;

            //Sending Mail
            try
            {
                client.Send(msg);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
