using Microsoft.EntityFrameworkCore;

namespace Exercicio2_Web_Api_CRUD.DataModels
{
    public class Context: DbContext
    {
        public Context() 
        {
            
        }
        public DbSet<Aluno> alunos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost; " + "initial Catalog=DbCad;User ID=usuario; " + "password=senha;language=Portuguese;Trusted_Connection=True;" + "TrustServerCertificate=True;");
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
