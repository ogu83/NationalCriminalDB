using NationalCriminalDB.Validators;
using System.ComponentModel.DataAnnotations;

namespace NationalCriminalDB.Models
{
    public class SearchModel
    {
        public enum SexType { Indetermined = 0, Male = 1, Female = 2, All = 3 }

        public SearchModel()
        {
            Sex = SexType.All;
            Nationality = "US Cuba Italy";
            MinAge = 13;
            MaxAge = 90;
            MinHeight = 100;
            MaxHeight = 300;
            MinWeight = 40;
            MaxWeight = 200;
        }

        public string ResultMessage { get; set; }
        public bool OnError { get; set; }

        [Display(Name = "Contains Name", Description = "Contains Filter, empty means this parameter not be used")]
        public string Name { get; set; }


        [Display(Name = "Contains Nationality", Description = "Contains Filter, empty means this parameter not be used, for multiple values please seperate keywords with spaces")]
        public string Nationality { get; set; }

        [Display(Name = "Sex", Description = "Select sex filtering")]
        [EnumDataType(typeof(SexType))]
        public SexType Sex { get; set; }

        [Display(Name = "Minimum Age", Description = "between range 5-2000 is acceptable")]
        [Range(5, 2000)]
        public int MinAge { get; set; }

        [Display(Name = "Maximum Age", Description = "between range 5-2000 is acceptable")]
        [Range(5, 2000)]
        [CheckMax("MinAge", ErrorMessage = "Maximum Age should greater or equal than Minimum Age")]
        public int MaxAge { get; set; }

        [Display(Name = "Minimum Height", Description = "between range 5-300 is acceptable")]
        [Range(0, 300.0)]
        public decimal MinHeight { get; set; }

        [Display(Name = "Maximum Height", Description = "between range 5-300 is acceptable")]
        [Range(0, 300.0)]
        [CheckMax("MinHeight", ErrorMessage = "Maximum Height should greater or equal than Minimum Height")]
        public decimal MaxHeight { get; set; }

        [Display(Name = "Minimum Weight", Description = "between range 40-200 is acceptable")]
        [Range(40, 200.0)]
        public decimal MinWeight { get; set; }

        [Display(Name = "Maximum Weight", Description = "between range 40-200 is acceptable")]
        [Range(40, 200.0)]
        [CheckMax("MinWeight", ErrorMessage = "Maximum Weight should greater or equal than Minimum Weight")]
        public decimal MaxWeight { get; set; }
    }
}