using AutoMapper;
using ProjectService.Models.DTOs;
using ProjectService.Models.Entities;

namespace ProjectService.Helpers;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Project, ProjectDto>()
            .ForMember(
                dest => dest.Majors,
                opt => opt.MapFrom(src => MajorsToString(src.Majors))
            )
            .ForMember(
                dest => dest.Contacts,
                opt => opt.MapFrom(src => new ContactsDto(){
                    Email = src.ContactsEmail,
                    Discord = src.ContactsDiscord,
                    Phone = src.ContactsPhone
                })
            );
    }

    private static List<string> MajorsToString(List<MajorEnum> majors)
    {
        var majorsOut = new List<string>();

        for (int i = 0; i < majors.Count; ++i)
            majorsOut.Add(Enum.GetName(typeof(MajorEnum), majors[i]));
        
        return majorsOut;
    }
}
