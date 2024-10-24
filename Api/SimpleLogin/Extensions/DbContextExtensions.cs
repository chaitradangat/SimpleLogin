using Microsoft.EntityFrameworkCore;
using SimpleLogin.Database.EfCore;

namespace SimpleLogin.Extensions
{
    public static class DbContextExtensions
    {
        public static void ConfigureDbContext(this WebApplicationBuilder builder)
        {
            var provider = builder.Services.BuildServiceProvider();

            IConfiguration configuration = provider.GetRequiredService<IConfiguration>();

            string dbConString = configuration["DbConnectionString"];

            builder.Services.AddDbContext<LoginDbContext>(options => {
            
                options.UseSqlServer(dbConString);
            
            },ServiceLifetime.Transient);
        }
    }
}
