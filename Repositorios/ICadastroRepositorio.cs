using ProjetoJogueJunto.Models;

namespace ProjetoJogueJunto.Repositorios
{
    public interface ICadastroRepositorio
    {
        CadastroModel Cadastrar(CadastroModel cadastro);
    }
}
