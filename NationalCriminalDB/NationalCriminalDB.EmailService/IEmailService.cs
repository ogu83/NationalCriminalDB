using System.Runtime.Serialization;
using System.ServiceModel;

namespace NationalCriminalDB.EmailService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
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

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
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
    }

    [DataContract]
    public class EmailSendResponse
    {
        [DataMember]
        public bool Result { get; set; }
    }
}
