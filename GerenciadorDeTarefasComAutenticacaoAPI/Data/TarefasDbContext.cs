using Microsoft.EntityFrameworkCore;

namespace GerenciadorDeTarefasComAutenticacaoAPI.Data
{
    public class TarefasDbContext : DbContext
    {
        public TarefasDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
