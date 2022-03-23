using AutoMapper;
using Business.Models;
using System.Text.Json;

namespace Business.External;

public class DataRetrievalService : IDataRetrievalService
{
    private readonly HttpClient _httpClient;
    private readonly IMapper _mapper;

    public DataRetrievalService(HttpClient httpClient, 
        IMapper mapper)
    {
        _httpClient = httpClient;
        _mapper = mapper;
    }

    public async Task<IEnumerable<User>> GetUsers()
    {
        var response = await _httpClient.GetAsync("/users");
        var responseString = await response.Content.ReadAsStringAsync();
        var typicodeUsers = JsonSerializer.Deserialize<IEnumerable<TypicodeUserDto>>(responseString, new JsonSerializerOptions(JsonSerializerDefaults.Web));
        if(typicodeUsers is null || !typicodeUsers.Any())
            return Enumerable.Empty<User>();
        return _mapper.Map<IEnumerable<User>>(typicodeUsers); 
    }
}

public interface IDataRetrievalService
{
    Task<IEnumerable<User>> GetUsers();
}
