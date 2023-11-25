using ProjetoJogueJunto.Data;
using ProjetoJogueJunto.Models;

namespace ProjetoJogueJunto.Repositorios
{
    public class CadastroRepositorio : ICadastroRepositorio
    {
        private readonly BancoContext _bancoContext;
        public CadastroRepositorio(BancoContext bancoContext)
        {
            this._bancoContext = bancoContext;
        }

        public CadastroModel BuscarPorLogin(string login)
        {
            return _bancoContext.Cadastros.FirstOrDefault(x => x.Email.ToUpper() == login.ToUpper());
        }

        public CadastroModel Cadastrar(CadastroModel cadastro)
        {
            _bancoContext.Cadastros.Add(cadastro);
            _bancoContext.SaveChanges();
            return cadastro;
        }
    }
}
