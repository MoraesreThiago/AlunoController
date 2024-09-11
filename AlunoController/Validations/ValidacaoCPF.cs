using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace AlunoController.Validations
{
    

    public class CpfValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var cpf = value as string;

            if (cpf == null)
            {
                return new ValidationResult("CPF é obrigatório.");
            }

            var regex = new Regex(@"^\d{11}$"); // CPF contém 11 dígitos

            if (!regex.IsMatch(cpf))
            {
                return new ValidationResult("CPF inválido.");
            }

            return ValidationResult.Success;
        }
    }

}
