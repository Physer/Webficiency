using Business.External;
using Business.Generation;
using Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Business;

public static class DependencyConfigurator
{
    public static void ConfigureBusinessDependencies(this IServiceCollection services, IConfiguration configuration)
    {
        services.ConfigureDataDependencies();

        services.AddHttpClient<IDataRetrievalService, DataRetrievalService>(httpClient =>
        {
            httpClient.BaseAddress = new Uri("https://jsonplaceholder.typicode.com");
        });

        services.AddScoped<IRepository, Repository>();
        services.AddScoped<IDataGenerator, DataGenerator>();

        services.AddAutoMapper(typeof(DependencyConfigurator));
    }
}
