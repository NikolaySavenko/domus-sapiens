using Microsoft.EntityFrameworkCore;

namespace FrontendService.Model
{
	public class PostgresContext : DbContext
	{
		public DbSet<User> Users { get; set; }
		public DbSet<Device> Devices { get; set; }
		public DbSet<ActionActivity> Actions { get; set; }

		public PostgresContext(DbContextOptions<PostgresContext> options): base(options)
		{
			Database.EnsureCreated();
		}

		#region Required
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<User>();
			modelBuilder.Entity<Device>();
			modelBuilder.Entity<ActionActivity>();
		}
		#endregion

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
			=> optionsBuilder.UseNpgsql(Environment.GetEnvironmentVariable("PostgreSQL"));
	}
}
