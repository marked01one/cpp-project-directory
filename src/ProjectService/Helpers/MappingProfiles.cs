using AutoMapper;
using ProjectService.Models.DTOs;


namespace ProjectService.Helpers;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        // Mappings for ProjectController.cs
        CreateMap<Project, ProjectDto>();
        CreateMap<Major, ProjectMajorDto>();
        CreateMap<Organization, ProjectOrganizationDto>();
        // Mappings for OrganizationController.cs
        CreateMap<Organization, OrganizationDto>();
        CreateMap<Project, OrganizationProjectDto>();
    }
}
