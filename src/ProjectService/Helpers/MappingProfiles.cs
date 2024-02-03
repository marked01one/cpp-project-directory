using AutoMapper;
using ProjectService.Models.DTOs;
using ProjectService.Models.Entities;

namespace ProjectService.Helpers;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Project, ProjectDto>();
    }
}
