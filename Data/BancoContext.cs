using Microsoft.EntityFrameworkCore;
using ProjetoJogueJunto.Models;

namespace ProjetoJogueJunto.Data
{
    public class BancoContext: DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
                
        }
        public DbSet<CadastroModel> Cadastros { get; set; }
    }
}
