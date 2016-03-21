using NationalCriminalDB.EmailService.Models;
using System.ServiceModel;

namespace NationalCriminalDB.EmailService
{
    [ServiceContract]
    public interface IEmailService
    {
        [OperationContract]
        EmailSendResponse SendCriminalRecords(EmailSendRequest request);
    }
}
