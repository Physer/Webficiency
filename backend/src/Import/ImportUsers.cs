using Business;
using Microsoft.Azure.Functions.Worker;

namespace Import;

public class ImportUsers
{
    private readonly IRepository _repository;

    public ImportUsers(IRepository repository)
    {
        _repository = repository;
    }

    [Function("import-users")]
    public void Run([TimerTrigger("0 */5 * * * *", RunOnStartup = true)] TimerInfo myTimer)
    {

    }
}
