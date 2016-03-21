using System.Runtime.Serialization;

namespace NationalCriminalDB.EmailService.Models
{
    [DataContract]
    public class EmailSendResponse
    {
        [DataMember]
        public bool Result { get; set; }
    }
}