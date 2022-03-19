using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace Data;

public static class DependencyConfigurator
{
    public static void ConfigureDataDependencies(this IServiceCollection services)
    {
        services.AddDbContext<WebficiencyContext>(options => options.UseSqlite(ConfigurationHelper.Instance.GetSqliteConnectionString()));
    }
}
