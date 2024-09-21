using System.ComponentModel.DataAnnotations;
using API_Aluno.Validations;

namespace API_Aluno.Models
{
    public class Aluno
    {
        [Required(ErrorMessage = "Campo obrigatório!")]
        public string? Nome { get; set; }


        [Required(ErrorMessage = "Campo obrigatório!")]
        [EmailAddress(ErrorMessage = "Email inválido!")]
        public string? Email { get; set; }


        [Required(ErrorMessage = "Campo obrigatório!")]
        public string? Telefone { get; set; }


        [Required(ErrorMessage = "Campo obrigatório!")]
        public string? CPF { get; set; }


        [Required(ErrorMessage = "Campo obrigatório!")]
        [ValidarMaioridade(ErrorMessage = "Aluno menor de idade.")]
        public int Idade { get; set; }
    }
}
