using Microsoft.EntityFrameworkCore;

namespace workWithDataBase
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=postgres;Port=5432;Database=postgres;Username=admin;Password=adminTestDatabase");
        }
    }
}