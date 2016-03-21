using System.Runtime.Serialization;

namespace NationalCriminalDB.EmailService.Models
{
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
}