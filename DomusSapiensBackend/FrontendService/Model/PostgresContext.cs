using Microsoft.EntityFrameworkCore;

namespace FrontendService.Model
{
	public class PostgresContext : DbContext
	{
		public DbSet<User> Users { get; set; }
		public DbSet<Device> Devices { get; set; }

		public PostgresContext(DbContextOptions<PostgresContext> options): base(options)
		{	
		}

		#region Required
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<User>();
			modelBuilder.Entity<Device>();
		}
		#endregion

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
			=> optionsBuilder.UseNpgsql(Environment.GetEnvironmentVariable("PostgreSQL"));
	}
}
