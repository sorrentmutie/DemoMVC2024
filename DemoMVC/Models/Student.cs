using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models;

public class Student
{
    public int Id { get; set; }
    [DisplayName("Nome")]
    [Required(ErrorMessage = "Il nome é obbligatorio")]
    [MinLength(3, ErrorMessage = "Il nome deve avere almeno 3 caratteri")]
    [MaxLength(10, ErrorMessage = "Il nome deve avere almeno 10 caratteri")]
    public string? Name { get; set; }
    public string? Email { get; set; } 
}
