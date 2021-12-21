using Microsoft.EntityFrameworkCore;

namespace AtividadeModulo3.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        public DbSet<Cliente> clientes { get; set; }
    } 
}
