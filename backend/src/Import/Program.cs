using Business;
using Microsoft.Extensions.Hosting;

var host = new HostBuilder()
    .ConfigureFunctionsWorkerDefaults()
    .ConfigureServices((context, services) => 
    {
        var configuration = context.Configuration;
        services.ConfigureBusinessDependencies(configuration); 
    })
    .Build();

host.Run();