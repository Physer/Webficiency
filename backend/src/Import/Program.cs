using Business;
using Microsoft.Extensions.Hosting;

var host = new HostBuilder()
    .ConfigureFunctionsWorkerDefaults()
    .ConfigureServices(services => services.ConfigureBusinessDependencies())
    .Build();

host.Run();