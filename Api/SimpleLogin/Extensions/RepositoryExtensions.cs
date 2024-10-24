using SimpleLogin.Database;
using SimpleLogin.Database.Repository;
using SimpleLogin.Repository;

namespace SimpleLogin.Extensions
{
    public static class RepositoryExtensions
    {
        public static void ConfigureRepositories(this WebApplicationBuilder builder)
        {
            builder.Services.AddTransient<ISampleRepository, SampleRepository>();
            builder.Services.AddTransient<IUnitOfWork,UnitOfWork>();
        }
    }
}
