using Business.Models;
using System.Text.Json;

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
        var response = await _httpClient.GetAsync("/users");
        var responseString = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<IEnumerable<User>>(responseString,new JsonSerializerOptions(JsonSerializerDefaults.Web)) ?? Enumerable.Empty<User>();
    }
}

public interface IDataRetrievalService
{
    Task<IEnumerable<User>> GetUsers();
}
