using Microsoft.EntityFrameworkCore;

namespace Trombinoctorat.Models
{
    public class RectoratContext : DbContext
    {
        public DbSet<Employe> Employe { get; set; }
        public DbSet<Employe> Poste { get; set; }
        public DbSet<Employe> Bureau { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=trombinoctorat;uid=root;pwd=azerty1234;");
        }
    }
}
