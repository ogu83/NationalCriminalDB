//using NationalCriminalDB.Models;
using System;
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
            var model = validationContext.ObjectInstance;
            var result = new ValidationResult(ErrorMessage);
            if (value != null)
            {
                var v = Convert.ToInt32(value);
                var minV = Convert.ToInt32(model.GetType().GetProperty(PropertyNames[0]).GetValue(model));
                if (minV <= v)
                    return ValidationResult.Success;
            }
            return result;
        }
    }
}