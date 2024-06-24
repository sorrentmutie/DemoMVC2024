
namespace DemoMVC.Models;

public class StudentsManager : IStudents
{
    private static List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "John", Email = "john@gmail.com" },
            new Student { Id = 2, Name = "Mary", Email = "mary@gmail.com" },
    };

    public StudentsManager()
    {
        
    }

    public void AddStudent(Student student)
    {
        students.Add(student);
    }

    public void DeleteStudent(int id)
    {
        students.RemoveAll(s => s.Id == id);
    }

    public Student? GetStudent(int id)
    {
        return students.FirstOrDefault(s => s.Id == id);
    }

    public IEnumerable<Student> GetStudents()
    {
        return students.OrderBy(s => s.Id);
    }

    public void UpdateStudent(Student student)
    {
        var studentDb = students.FirstOrDefault(s => s.Id == student.Id);
        if (studentDb != null)
        {
           students.Remove(studentDb);
           students.Add(student);  
        }
    }
}
