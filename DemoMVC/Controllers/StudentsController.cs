using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IStudents students;
        private readonly ISchoolData schoolData;

        public StudentsController(IStudents students, ISchoolData schoolData)
        {
            this.students = students;
            this.schoolData = schoolData;
        }

        public IActionResult Index()
        {
            return View(schoolData.GetStudentsIndexViewModel());
           // return View(students.GetStudents());
        }

        public IActionResult Details(int id)
        {
            var student = students.GetStudent(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (!ModelState.IsValid)
            {
                return View(student);
            }
            students.AddStudent(student);
            return RedirectToAction("Index");
        }
        
        public IActionResult Edit(int id)
        {
            var student = students.GetStudent(id);
            if(student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        [HttpPost]
        public IActionResult Edit(Student student)
        {
            students.UpdateStudent(student);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var student = students.GetStudent(id);
            if(student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        [HttpPost]
        public IActionResult Delete(Student student)
        {
            students.DeleteStudent(student.Id);
            return RedirectToAction("Index");
        }

    }
}
