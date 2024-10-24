using Azure.Identity;
using Microsoft.Extensions.Configuration.AzureKeyVault;

namespace SimpleLogin.Extensions
{
    public static class ReadConfiguration
    {
        public static void AddConfiguration(this WebApplicationBuilder builder, string[] args)
        {
            var keyVaultURL = builder.Configuration["KeyVaultConfiguration:KeyVaultURL"];

            var cfgbuilder = new ConfigurationBuilder()
                            .SetBasePath(Directory.GetCurrentDirectory())
                            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                            .AddEnvironmentVariables()
                            .AddCommandLine(args)
                            .AddAzureKeyVault(new Uri(keyVaultURL), new DefaultAzureCredential());
                            
            IConfiguration configuration = cfgbuilder.Build();

            builder.Services.AddSingleton<IConfiguration>(configuration);
        }
    }
}
