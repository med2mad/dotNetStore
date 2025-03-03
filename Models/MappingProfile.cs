using AutoMapper;

namespace dotNetStore.Models;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<User, User>();
        CreateMap<User, UserDTO>();
        CreateMap<Contact, Contact>();
        CreateMap<Contact, ContactDTO>();
    }
}
