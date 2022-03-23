using AutoMapper;
using Business.External;
using Business.Models;

namespace Business.Mappings;

public class TypicodeProfile : Profile
{
    public TypicodeProfile()
    {
        CreateMap<TypicodeUserDto, User>()
            .ForMember(dst => dst.EmailAddress, opt => opt.MapFrom(src => src.Email))
            .ForMember(dst => dst.PhoneNumber, opt => opt.MapFrom(src => src.Phone))
            .ForMember(dst => dst.Address, opt => opt.Ignore())
            .ForMember(dst => dst.Company, opt => opt.Ignore())
            .ConstructUsing(src => new User(src.Username!, src.Email!))
            //TODO: Nested types
            ;
    }
}
