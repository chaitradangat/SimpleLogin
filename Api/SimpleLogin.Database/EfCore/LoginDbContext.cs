using Microsoft.EntityFrameworkCore;
using SimpleLogin.Database.Configuration;
using SimpleLogin.Domain;

namespace SimpleLogin.Database.EfCore
{
    public class LoginDbContext : DbContext
    {
        public LoginDbContext() { }

        DbSet<Sample> Samples { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new SampleConfiguration().Configure(modelBuilder.Entity<Sample>());
        }


    }
}
