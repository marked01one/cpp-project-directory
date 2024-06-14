using AutoMapper;
using ProjectService.Models.DTOs;


namespace ProjectService.Helpers;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Project, ProjectDto>();
        CreateMap<Major, ProjectMajorDto>();
        // CreateMap<Organization, ProjectOrganizationDto>();
        
        CreateMap<Organization, OrganizationDto>();
        CreateMap<Project, OrganizationProjectDto>();
    }
}
