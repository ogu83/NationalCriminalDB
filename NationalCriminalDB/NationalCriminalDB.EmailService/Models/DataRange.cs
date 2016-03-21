using System.Runtime.Serialization;

namespace NationalCriminalDB.EmailService.Models
{
    [DataContract]
    public class DataRange<T>
    {
        public DataRange(T min, T max)
        {
            Minimum = min;
            Maximum = max;
        }

        [DataMember]
        public T Minimum { get; set; }
        [DataMember]
        public T Maximum { get; set; }
    }
}