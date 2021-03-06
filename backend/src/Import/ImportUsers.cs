using Business;
using Business.External;
using Business.Generation;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using System.Net;

namespace Import;

public class ImportUsers
{
    private readonly IDataRetrievalService _dataRetrievalService;
    private readonly IRepository _repository;
    private readonly ILogger _logger;
    private readonly IDataGenerator _dataGenerator;

    public ImportUsers(IDataRetrievalService dataRetrievalService,
        IRepository repository,
        ILogger<ImportUsers> logger,
        IDataGenerator dataGenerator)
    {
        _dataRetrievalService = dataRetrievalService;
        _repository = repository;
        _logger = logger;
        _dataGenerator = dataGenerator;
    }

    [Function("import-external-users")]
    public async Task<HttpResponseData> ImportExternalUsers([HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequestData req)
    {
        var users = await _dataRetrievalService.GetUsers();
        if (users is null || users?.Any() == false)
        {
            _logger.LogInformation("No users found to import");
            return req.CreateResponse(HttpStatusCode.OK);
        }

        _logger.LogInformation($"Downloaded {users?.Count()} users");
        _logger.LogInformation("Saving users to the database");
        _repository.SaveUsers(users!);
        return req.CreateResponse(HttpStatusCode.Accepted);
    }

    [Function("import-generated-users")]
    public HttpResponseData ImportGeneratedUsers([HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequestData req, string? amount) 
    {
        var users = _dataGenerator.GenerateUsers();
        if (users is null || users?.Any() == false)
        {
            _logger.LogInformation("No users found to import");
            return req.CreateResponse(HttpStatusCode.OK);
        }

        _logger.LogInformation($"Generated {users?.Count()} users");
        _logger.LogInformation("Saving users to the database");
        _repository.SaveUsers(users!);
        return req.CreateResponse(HttpStatusCode.Accepted);
    }
}
