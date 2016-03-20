using System.Configuration;
using System.Net.Mail;

namespace NationalCriminalDB.EmailService.Helpers
{
    public class EmailHelper
    {
        protected static int SmtpPort { get { return int.Parse(ConfigurationManager.AppSettings.Get("SmtpPort")); } }
        protected static string SmtpHost { get { return ConfigurationManager.AppSettings.Get("SmtpHost"); } }
        protected static bool SmtpEnableSSL { get { return bool.Parse(ConfigurationManager.AppSettings.Get("SmtpEnableSSL")); } }
        protected static int SmtpTimeout { get { return int.Parse(ConfigurationManager.AppSettings.Get("SmtpTimeout")); } }
        protected static string SmtpUsername { get { return ConfigurationManager.AppSettings.Get("SmtpUsername"); } }
        protected static string SmtpPassword { get { return ConfigurationManager.AppSettings.Get("SmtpPassword"); } }
        protected static string SmtpFrom { get { return ConfigurationManager.AppSettings.Get("SmtpFrom"); } }

        protected static SmtpClient getClient()
        {
            var client = new SmtpClient();
            client.Port = SmtpPort;
            client.Host = SmtpHost;
            client.EnableSsl = SmtpEnableSSL;
            client.Timeout = SmtpTimeout;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential(SmtpUsername, SmtpPassword);
            return client;
        }

        public static void SendMail(MailMessage mm)
        {
            var client = getClient();
            client.Send(mm);
        }
    }
}