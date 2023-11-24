using ProjetoJogueJunto.Models;

namespace ProjetoJogueJunto.Repositorios
{
    public interface ICadastroRepositorio
    {
        CadastroModel BuscarPorLogin(string login);
        CadastroModel Cadastrar(CadastroModel cadastro);
    }
}
