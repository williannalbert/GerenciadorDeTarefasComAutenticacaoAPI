using GerenciadorDeTarefasComAutenticacaoAPI.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorDeTarefasComAutenticacaoAPI.Data
{
    public class UsuarioDbContext : IdentityDbContext<Usuario>
    {
        public UsuarioDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
