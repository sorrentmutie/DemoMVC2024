using DemoMVC.ViewModels;

namespace DemoMVC.Models;

public interface IStudents
{
    IEnumerable<Student> GetStudents();
    Student? GetStudent(int id);
    void AddStudent(Student student);
    void UpdateStudent(Student student);
    void DeleteStudent(int id);
}

public interface ISchoolData
{
    StudentsIndexViewModel GetStudentsIndexViewModel();
}