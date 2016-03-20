using System.ComponentModel.DataAnnotations;

namespace NationalCriminalDB.Validators
{
    public class CheckMaxAttribute : ValidationAttribute
    {
        public CheckMaxAttribute(params string[] propertyNames)
        {
            PropertyNames = propertyNames;
        }

        public string[] PropertyNames { get; private set; }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var val = (int)value;
            if ((int)(validationContext.Items[PropertyNames[0]]) <= val)
                return new ValidationResult(ErrorMessage);
            else
                return ValidationResult.Success;
        }
    }
}