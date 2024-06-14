namespace ProjectService.Models.DTOs;

public class ProjectDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public ProjectOrganizationDto Organization { get; set; }
    public string CompensationType { get; set; }
    public bool IsPaid { get; set;}
    public double? Wage { get; set; }
    public List<ProjectMajorDto> Majors { get; set; }
    public string ContactsEmail { get; set; }
    #nullable enable
    public string? ContactsPhone { get; set; }
    public string? ContactsDiscord { get; set; }
    #nullable disable
}

public class ProjectMajorDto
{
    public string Name { get; set; }
    public string Acronym { get; set; }
}

public class ProjectOrganizationDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
}
