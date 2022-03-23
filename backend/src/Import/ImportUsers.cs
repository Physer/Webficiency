using Business;
using Business.External;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace Import;

public class ImportUsers
{
    private readonly IDataRetrievalService _dataRetrievalService;
    private readonly IRepository _repository;
    private readonly ILogger _logger;

    public ImportUsers(IDataRetrievalService dataRetrievalService,
        IRepository repository, 
        ILogger<ImportUsers> logger)
    {
        _dataRetrievalService = dataRetrievalService;
        _repository = repository;
        _logger = logger;
    }

    [Function("import-users")]
    public async Task Run([TimerTrigger("0 */5 * * * *", RunOnStartup = true)] TimerInfo myTimer)
    {
        var users = await _dataRetrievalService.GetUsers();
        if (users is null || users?.Any() == false)
        {
            _logger.LogInformation("No users found to import");
            return;
        }

        _logger.LogInformation($"Downloaded {users?.Count()} users");
        _logger.LogInformation("Saving users to the database");
        _repository.SaveUsers(users!);
    }
}
