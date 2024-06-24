using DemoMVC.ViewModels;

namespace DemoMVC.Models;

public class SchoolManager : ISchoolData
{
    private readonly IStudents students;

    public SchoolManager(IStudents students)
    {
        this.students = students;
    }

    public StudentsIndexViewModel GetStudentsIndexViewModel()
    {
        return new StudentsIndexViewModel
        {
            Title = "Universita degli studi",
            TotalNumberOfStudents = 10000,
            Students = students.GetStudents(),
            Professors = new List<Professor>
            {
                new Professor { Id = 1, Name = "Prof. Rossi", }
            }
        };
    }
}
