using Microsoft.EntityFrameworkCore;
using RestApi_Exercicio_2.DataModels;

namespace RestApi_Exercicio_2
{
    public class Context : DbContext
    {
        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Curso> Curso { get; set; }
        public DbSet<Matricula> Matricula { get; set; }

        public Context() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=localhost; Initial Catalog=AtosEntity3; User ID=AtosEntity3; Password=AtosEntity3; Language=Portuguese; Trusted_Connection=True; TrustServerCertificate=True;");
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
