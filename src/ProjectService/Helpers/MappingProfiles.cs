using AutoMapper;
using ProjectService.Models.DTOs;
using ProjectService.Models;


namespace ProjectService.Helpers;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Project, ProjectDto>()
            .ForMember(
                dest => dest.Contacts,
                opt => opt.MapFrom(src => new ContactsDto(){
                    Email = src.ContactsEmail,
                    Discord = src.ContactsDiscord,
                    Phone = src.ContactsPhone
                })
            );
    }
}
