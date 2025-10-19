using Microsoft.EntityFrameworkCore;
using ProjetoCadastroUsuarios.Models;

namespace ProjetoCadastroUsuarios.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; } = default!;

    }


}

