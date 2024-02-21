using System.ComponentModel.DataAnnotations;
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
    
    [RegularExpression(@"^((([!#$%&'*+\-/=?^_`{|}~\w])|([!#$%&'*+\-/=?^_`{|}~\w][!#$%&'*+\-/=?^_`{|}~\.\w]{0,}[!#$%&'*+\-/=?^_`{|}~\w]))[@]\w+([-.]\w+)*\.\w+([-.]\w+)*)$", ErrorMessage = "Invalid email address!")]
    public string ContactsEmail { get; set; }

    [RegularExpression(@"^[2-9]\d{2}-\d{3}-\d{4}$", ErrorMessage = "Invalid US Phone Number!")]
    
    public string ContactsPhone { get; set; }
    
    public string ContactsDiscord { get; set; }
    
    public List<MajorEnum> Majors { get; set; }
}
