using System;
using System.Configuration;
using System.IO;
using System.Linq;
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
        protected static int MaxAttachmentCount { get { return int.Parse(ConfigurationManager.AppSettings.Get("MaxAttachmentCount")); } }

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

        /// <summary>
        /// Sends Mail
        /// </summary>
        /// <param name="mm">Mail Message</param>
        public static void SendMail(MailMessage mm)
        {
            var client = getClient();
            client.Send(mm);
        }

        /// <summary>
        /// Sends mail to subscriber with attachments
        /// </summary>
        /// <param name="to">Subscriber email address</param>
        /// <param name="attachmentFileNames">Attachment File Paths</param>
        public static void SendMailWithAttachments(string to, string[] attachmentFileNames)
        {
            var message = new MailMessage(SmtpFrom, to);
            var count = attachmentFileNames.Length;
            foreach (var filename in attachmentFileNames)
                if (File.Exists(filename))
                    message.Attachments.Add(new Attachment(filename));
            message.Body = string.Format("This message contains {0} criminal record according to your search criteria", count);
            message.Subject = "National Criminal DB Search Result";
            try
            {
                SendMail(message);
            }
            catch (Exception ex)
            {
                //TODO: Log Exception
                throw ex;
            }
        }

        /// <summary>
        /// Sends multiple mail to a subscriber with attachments according to max attachment count.
        /// For example with maxFileCount=10 and attachment count = 30 then 3 mail will be sended
        /// </summary>
        /// <param name="to">Subscriber email address</param>
        /// <param name="attachmentFileNames">Attachment File Paths</param>
        /// <param name="maxFileCount">Attachment capacity of single mail, to use default value don't assign any value leave it -1, it will be managed by webconfig file</param>
        public static void SendGroupMailWithAttachments(string to, string[] attachmentFileNames, int maxFileCount = -1)
        {
            if (maxFileCount < 0)
                maxFileCount = MaxAttachmentCount;

            int n = 0;
            while (attachmentFileNames.Length > n)
            {
                var files = attachmentFileNames.Skip(n).Take(maxFileCount).ToList();
                SendMailWithAttachments(to, files.ToArray());
                n += maxFileCount;
            }
        }
    }
}