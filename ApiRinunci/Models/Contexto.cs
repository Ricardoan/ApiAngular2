using Microsoft.EntityFrameworkCore;

namespace ApiRinunci.Models
{
    public class Contexto : DbContext
    {
        public Contexto (DbContextOptions<Contexto> opcoes) : base (opcoes) { }

        public DbSet<Produto> Produtos { get; set; }
    }

}
