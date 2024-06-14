using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

public class Project
{
    public Guid Id { get; set; }
    public Guid OrganizationId { get; set; }
    [JsonIgnore]
    public Organization Organization { get; set; } = null!;
    public List<Major> Majors { get; } = [];
    public string Name { get; set; }
    public string Description { get; set; }
    public CompensationTypeEnum CompensationType { get; set; }
    public bool IsPaid { get; }
    public double? Wage { get; set; }
    [RegularExpression(@"^((([!#$%&'*+\-/=?^_`{|}~\w])|([!#$%&'*+\-/=?^_`{|}~\w][!#$%&'*+\-/=?^_`{|}~\.\w]{0,}[!#$%&'*+\-/=?^_`{|}~\w]))[@]\w+([-.]\w+)*\.\w+([-.]\w+)*)$", ErrorMessage = "Invalid email address!")]
    public string ContactsEmail { get; set; }
    [RegularExpression(@"^[2-9]\d{2}-\d{3}-\d{4}$", ErrorMessage = "Invalid US Phone Number!")]
    #nullable enable
    public string? ContactsPhone { get; set; }
    public string? ContactsDiscord { get; set; }
    #nullable disable

    public Project()
    {
        IsPaid = CompensationType != CompensationTypeEnum.Volunteer;
    }

}

public class Major
{
    public Guid Id { get; set;}
    public List<Project> Projects { get; } = [];
    public string Name { get; set; }
    public string Acronym { get; set; }
}

public class Organization
{
    public Guid Id { get; set;}
    public List<Project> Projects { get; } = [];
    public string Name { get; set; }
}

public enum CompensationTypeEnum
{
    Volunteer,
    Hourly,
    Semesterly
}

public class ProjectMajor
{
    public Guid ProjectId { get; set; }
    public Guid MajorId { get; set; }
}

