using Microsoft.Extensions.Configuration;

namespace Data;

public static class ConfigurationHelper
{
    private static readonly IConfiguration _configuration;
    
    static ConfigurationHelper()
    {
        var configurationBuilder = new ConfigurationBuilder();
        var environmentName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
        configurationBuilder.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
        configurationBuilder.AddJsonFile($"appsettings.{environmentName}.json", optional: true, reloadOnChange: true);
        _configuration = configurationBuilder.Build();
    }

    public static IConfiguration GetConfiguration() => _configuration;
}
