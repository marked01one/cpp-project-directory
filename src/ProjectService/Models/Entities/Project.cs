using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectService.Models.Entities;

[Table("Projects")]
public class Project
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Organization { get; set; }
    public CompensationEnum Compensation { get; set; }
    public string Description { get; set; }
    public string ContactEmail { get; set; }
    public List<MajorEnum> Majors { get; set; }
}
