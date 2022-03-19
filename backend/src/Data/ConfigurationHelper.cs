using Microsoft.Extensions.Configuration;

namespace Data;

public class ConfigurationHelper
{
    private static ConfigurationHelper? _instance;
    public static ConfigurationHelper Instance
    {
        get
        {
            if (_instance is null)
                _instance = new ConfigurationHelper();
            return _instance;
        }
    }

    private static readonly IConfiguration _configuration;
    
    static ConfigurationHelper()
    {
        var configurationBuilder = new ConfigurationBuilder();
        var environmentName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
        configurationBuilder.AddJsonFile("dataSettings.json", optional: false, reloadOnChange: true);
        configurationBuilder.AddJsonFile($"dataSettings.{environmentName}.json", optional: true, reloadOnChange: true);
        _configuration = configurationBuilder.Build();
    }

    public string GetSqliteConnectionString()
    {
        var dbPath = "Data Source=";
        if (!bool.TryParse(_configuration["InMemoryDatabase"], out var useInMemoryDatabase))
            throw new ArgumentException("Invalid configuration");
        if (useInMemoryDatabase)
            dbPath += ":memory:";
        else
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            dbPath += Path.Join(path, "webficiency.db");
        }
        return dbPath;
    }
}
