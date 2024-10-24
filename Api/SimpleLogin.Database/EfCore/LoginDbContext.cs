using Microsoft.EntityFrameworkCore;
using SimpleLogin.Database.Configuration;
using SimpleLogin.Domain;

namespace SimpleLogin.Database.EfCore
{
    public class LoginDbContext : DbContext
    {
        public DbSet<Sample> Samples { get; set; }

        public LoginDbContext(DbContextOptions<LoginDbContext> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new SampleConfiguration().Configure(modelBuilder.Entity<Sample>());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        

    }
}
