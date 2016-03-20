using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace NationalCriminalDB.EmailService
{
    public class EmailService : IEmailService
    {
        public EmailSendResponse SendCriminalRecords(EmailSendRequest request)
        {
            var response = new EmailSendResponse();
            //TODO: Create Background Process
            return response;
        }
    }
}
