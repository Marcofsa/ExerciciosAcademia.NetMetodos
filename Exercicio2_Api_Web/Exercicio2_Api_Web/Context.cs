using Exercicio2_Api_Web.DataModels;
using Microsoft.EntityFrameworkCore;

namespace Exercicio2_Api_Web
{
    public class Context : DbContext
    {
        public Context() 
        { 
        
        }
        public DbSet<Pessoa> Pessoas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost; " +
                "initial Catalog=AtosApi2;User ID=Api2; " +
                "password=senha;language=Portuguese;Trusted_Connection=True;" +
                "TrustServerCertificate=True;");
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
