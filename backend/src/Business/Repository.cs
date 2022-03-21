using AutoMapper;
using Business.Models;
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

    public IEnumerable<User> GetUsers() => _mapper.Map<IEnumerable<User>>(_webficiencyContext.Users?.AsNoTracking()?.ToList());
}

public interface IRepository
{
    IEnumerable<User> GetUsers();
}
