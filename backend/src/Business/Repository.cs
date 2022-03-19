using AutoMapper;
using Data;
using Microsoft.EntityFrameworkCore;

namespace Business;

public class Repository : IRepository
{
    private readonly IMapper _mapper;
    private readonly WebficiencyContext _webficiencyContext;

    public Repository(WebficiencyContext webficiencyContext, 
        IMapper mapper)
    {
        _webficiencyContext = webficiencyContext;
        _mapper = mapper;
    }

    public IEnumerable<T> GetAll<T>() where T : class, new() => _webficiencyContext.Set<T>().AsNoTracking().ToList();
}

public interface IRepository
{
    IEnumerable<T> GetAll<T>() where T : class, new();
}
