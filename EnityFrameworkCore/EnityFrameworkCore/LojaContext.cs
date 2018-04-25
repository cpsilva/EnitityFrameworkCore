using Microsoft.EntityFrameworkCore;

namespace EnityFrameworkCore
{
    public class LojaContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

        public LojaContext()
        { }

        public LojaContext(DbContextOptions<LojaContext> options) : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    //.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LojaDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                    .UseSqlServer("Data Source=PE00Q1ME\\SQLEXPRESS;Initial Catalog=LojaDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }
    }
}