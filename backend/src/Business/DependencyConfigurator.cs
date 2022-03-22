using Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Business;

public static class DependencyConfigurator
{
    public static void ConfigureBusinessDependencies(this IServiceCollection services, IConfiguration configuration)
    {
        services.ConfigureDataDependencies();

        services.AddScoped<IRepository, Repository>();

        services.AddAutoMapper(typeof(DependencyConfigurator));
    }
}
