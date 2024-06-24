using DemoMVC.Models;

namespace DemoMVC.ViewModels;

public class StudentsIndexViewModel
{
    public IEnumerable<Student>? Students { get; set; }
    public int TotalNumberOfStudents { get; set; }
    public string Title { get; set; } = "";
    public IEnumerable<Professor>? Professors { get; set; }
}
