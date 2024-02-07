namespace ProjectService.Models.DTOs;

public class ProjectDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Organization { get; set; }
    public string Compensation { get; set; }
    public string Description { get; set; }
    public string ContactEmail { get; set; }
    public List<string> Majors { get; set; }
}
