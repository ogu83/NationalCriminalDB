using System.Runtime.Serialization;
using System.ServiceModel;

namespace NationalCriminalDB.EmailService
{
    [ServiceContract]
    public interface IEmailService
    {
        [OperationContract]
        EmailSendResponse SendCriminalRecords(EmailSendRequest request);
    }

    [DataContract]
    public class DataRange<T>
    {
        [DataMember]
        public T Minimum { get; set; }
        [DataMember]
        public T Maximum { get; set; }
    }

    [DataContract]
    public class EmailSendRequest
    {
        public enum SexType { Indetermined = 0, Male = 1, Female = 2, All = 3 }

        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public DataRange<int> Age { get; set; }
        [DataMember]
        public DataRange<decimal> Height { get; set; }
        [DataMember]
        public DataRange<decimal> Weight { get; set; }
        [DataMember]
        public string Nationality { get; set; }
        [DataMember]
        public SexType Sex { get; set; }
        [DataMember]
        public string Email { get; set; }
    }

    [DataContract]
    public class EmailSendResponse
    {
        [DataMember]
        public bool Result { get; set; }
    }
}
