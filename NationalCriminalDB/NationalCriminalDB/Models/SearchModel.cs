using NationalCriminalDB.Validators;
using System.ComponentModel.DataAnnotations;

namespace NationalCriminalDB.Models
{
    public class SearchModel
    {
        public enum SexType { Indetermined = 0, Male = 1, Female = 2, All = 3 }

        public string ResultMessage { get; set; }
        public bool OnError { get; set; }

        public string Name { get; set; }

        [Range(0, 2000)]
        public int MinAge { get; set; }
        [Range(0, 2000)]
        [CheckMax("MinAge", "Maximum Age should greater or equal than Minimum Age")]
        public int MaxAge { get; set; }

        [Range(0, 300.0)]
        public decimal MinHeight { get; set; }
        [Range(0, 300.0)]
        [CheckMax("MinHeight", "Maximum Height should greater or equal than Minimum Height")]
        public decimal MaxHeight { get; set; }

        [Range(0, 200.0)]
        public decimal MinWeight { get; set; }
        [Range(0, 200.0)]
        [CheckMax("MinWeight", "Maximum Weight should greater or equal than Minimum Weight")]
        public decimal MaxWeight { get; set; }

        public string Nationality { get; set; }

        [EnumDataType(typeof(SexType))]
        public SexType Sex { get; set; }
    }
}