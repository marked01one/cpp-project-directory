using AutoMapper;
using ProjectService.Models.DTOs;
using ProjectService.Models;


namespace ProjectService.Helpers;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Project, ProjectDto>();
        CreateMap<Major, ProjectMajorDto>();
        CreateMap<Organization, ProjectOrganizationDto>();
    }
}
