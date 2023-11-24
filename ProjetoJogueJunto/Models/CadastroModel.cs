using System.ComponentModel.DataAnnotations;

namespace ProjetoJogueJunto.Models
{
    public class CadastroModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o nome do usuário")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Digite o e-mail do usuário")]
        [EmailAddress(ErrorMessage = "O email informado é inválido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Digite a data de nascimento do usuário")]
        public string DataNascimento { get; set; }
        [Required(ErrorMessage = "Digite uma senha")]
        public string Senha { get; set; }
        public bool SenhaValida(string senha)
        {
            return Senha == senha;
        }
    }
}
