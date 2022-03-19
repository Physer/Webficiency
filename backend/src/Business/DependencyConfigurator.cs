using Data;
using Microsoft.Extensions.DependencyInjection;

namespace Business;

public static class DependencyConfigurator
{
    public static void ConfigureBusinessDependencies(this IServiceCollection services)
    {
        services.ConfigureDataDependencies();

        services.AddScoped<IRepository, Repository>();
    }
}
