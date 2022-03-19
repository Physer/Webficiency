using AutoMapper;
using Business.Models;

namespace Business.Mappings;

public class RepositoryProfile : Profile
{
    public RepositoryProfile()
    {
        CreateMap<User, Data.Entities.User>();
        CreateMap<Address, Data.Entities.Address>();
        CreateMap<Album, Data.Entities.Album>();
        CreateMap<Comment, Data.Entities.Comment>();
        CreateMap<Company, Data.Entities.Company>();
        CreateMap<Photo, Data.Entities.Photo>();
        CreateMap<Post, Data.Entities.Post>();
        CreateMap<Todo, Data.Entities.Todo>();
    }
}
