using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace AlunoController.Validations
{

    public class ValidRaAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var ra = value as string;

            if (ra == null)
            {
                return new ValidationResult("RA é obrigatório.");
            }

            var regex = new Regex(@"^RA\d{6}$");

            if (!regex.IsMatch(ra))
            {
                return new ValidationResult("O RA deve começar com 'RA' seguido de 6 dígitos.");
            }

            return ValidationResult.Success;
        }
    }

}
