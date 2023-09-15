using GerenciadorDeTarefasComAutenticacaoAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorDeTarefasComAutenticacaoAPI.Data
{
    public class TarefasDbContext : DbContext
    {
        public TarefasDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Tarefa> Tarefa { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tarefa>()
                .HasMany(t => t.Categoria)
                .WithOne(c => c.Tarefa)
                .HasForeignKey(c => c.Tarefa.Id);
        }
    }
}
