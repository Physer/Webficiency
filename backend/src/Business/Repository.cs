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
    public void SaveUsers(IEnumerable<User> users) => _webficiencyContext.Users?.AddRange(_mapper.Map<IEnumerable<Data.Entities.User>>(users));
}

public interface IRepository
{
    IEnumerable<User> GetUsers();
    void SaveUsers(IEnumerable<User> users);
}
