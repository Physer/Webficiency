using Business.Models;

namespace Business;

public class DataRetrievalService : IDataRetrievalService
{
    private readonly HttpClient _httpClient;

    public DataRetrievalService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<IEnumerable<User>> GetUsers()
    {
        throw new NotImplementedException();
    }
}

public interface IDataRetrievalService
{

}
