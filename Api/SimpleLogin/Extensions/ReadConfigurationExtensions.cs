using Azure.Identity;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;

namespace SimpleLogin.Extensions
{
    public static class ReadConfigurationExtensions
    {
        public static void UseConfiguration(this WebApplicationBuilder builder, string[] args)
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
