namespace ProjectService.Models.DTOs;

public class OrganizationDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public List<OrganizationProjectDto> Projects { get; set; }
}

public class OrganizationProjectDto
{
    public string Name { get; set; }
    public string Description { get; set; }
}