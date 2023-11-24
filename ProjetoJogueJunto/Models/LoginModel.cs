using System.ComponentModel.DataAnnotations;

namespace ProjetoJogueJunto.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Digite o e-mail do usuário")]
        [EmailAddress(ErrorMessage = "O email informado é inválido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Digite o e-mail do usuário")]
        public string Senha { get; set; }
    }
}
