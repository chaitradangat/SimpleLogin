using Azure.Identity;
using SimpleLogin.Domain.Constants;

namespace SimpleLogin.Extensions
{
    public static class ReadConfiguration
    {
        public static void AddConfiguration(this WebApplicationBuilder builder, string[] args)
        {
            var keyVaultURL = "";//settings["KeyVaultConfiguration:KeyVaultURL"];
            var keyVaultClientId = "";//settings["KeyVaultConfiguration:ClientId"];
            var keyVaultClientSecret = "";//settings["KeyVaultConfiguration:ClientSecret"];


            var cfgbuilder = new ConfigurationBuilder()
                            .SetBasePath(Directory.GetCurrentDirectory())
                            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                            .AddEnvironmentVariables()
                            .AddCommandLine(args)
                            .AddAzureKeyVault(new Uri(""), new DefaultAzureCredential() );
                            

            IConfiguration configuration = cfgbuilder.Build();

            builder.Services.AddSingleton<IConfiguration>(configuration);
        }
    }
}
