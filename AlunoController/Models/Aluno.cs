using AlunoController.Validations;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace AlunoController.Models
{

    public class Aluno
    {
        [Required(ErrorMessage = "O nome é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O RA é obrigatório.")]
        [ValidRa(ErrorMessage = "O RA deve começar com 'RA' seguido de 6 dígitos.")]
        public string Ra { get; set; }

        [Required(ErrorMessage = "O email é obrigatório.")]
        [EmailAddress(ErrorMessage = "O email deve ser válido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O CPF é obrigatório.")]
        [CpfValidation(ErrorMessage = "CPF inválido.")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "O campo ativo é obrigatório.")]
        public bool Ativo { get; set; }
    }

}
