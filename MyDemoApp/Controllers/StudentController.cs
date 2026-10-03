using Microsoft.AspNetCore.Mvc;
using MyDemoApp.Models;

namespace MyDemoApp.Controllers
{
    public class StudentController : Controller
    {
        public StudentController()
        {

        }
        public IActionResult Index()
        {
            Student student = new Student
            {
                RollNumber = 1,
                Name = "Azhar Hussain Khan",
                Gender = "Male",
                DateOfBirth = new DateTime(1993, 10, 15)
            };
            return View(student);
        }
        public IActionResult GetStudentsData()
        {
            List<Student> students = new List<Student>
            {
                new Student { RollNumber = 1, Name = "Azhar Hussain Khan", Gender = "Male", DateOfBirth = new DateTime(1993, 10, 15) },
                new Student { RollNumber = 2, Name = "Mohammed Zubair", Gender = "Male", DateOfBirth = new DateTime(1995, 5, 20) },
                new Student { RollNumber = 3, Name = "Shaista Khatoon", Gender = "Female", DateOfBirth = new DateTime(1994, 8, 10) },
                new Student { RollNumber = 4, Name = "Ayesha Khan", Gender = "Female", DateOfBirth = new DateTime(1996, 12, 5) },
                new Student { RollNumber = 5, Name = "Ali Raza", Gender = "Male", DateOfBirth = new DateTime(1992, 3, 15) },
                new Student { RollNumber = 6, Name = "Fatima Zahra", Gender = "Female", DateOfBirth = new DateTime(1997, 7, 25) },
                new Student { RollNumber = 7, Name = "Hassan Ali", Gender = "Male", DateOfBirth = new DateTime(1991, 11, 30) },
                new Student { RollNumber = 8, Name = "Sana Khan", Gender = "Female", DateOfBirth = new DateTime(1998, 2, 18) },
                new Student { RollNumber = 9, Name = "Imran Qureshi", Gender = "Male", DateOfBirth = new DateTime(1990, 9, 12) },
                new Student { RollNumber = 10, Name = "Zainab Malik", Gender = "Female", DateOfBirth = new DateTime(1999, 4, 22) },
                new Student { RollNumber = 11, Name = "Azhaan Hussain Khan", Gender = "Male", DateOfBirth = new DateTime(2020, 6, 21) },
            };

            return View(students);
        }
        public IActionResult GetListData()
        {
            List<Student> students = new List<Student>
            {
                new Student { RollNumber = 1, Name = "Azhar Hussain Khan", Gender = "Male", DateOfBirth = new DateTime(1993, 10, 15) },
                new Student { RollNumber = 2, Name = "Mohammed Zubair", Gender = "Male", DateOfBirth = new DateTime(1995, 5, 20) },
                new Student { RollNumber = 3, Name = "Shaista Khatoon", Gender = "Female", DateOfBirth = new DateTime(1994, 8, 10) },
                new Student { RollNumber = 4, Name = "Ayesha Khan", Gender = "Female", DateOfBirth = new DateTime(1996, 12, 5) },
                new Student { RollNumber = 5, Name = "Ali Raza", Gender = "Male", DateOfBirth = new DateTime(1992, 3, 15) },
                new Student { RollNumber = 6, Name = "Fatima Zahra", Gender = "Female", DateOfBirth = new DateTime(1997, 7, 25) },
                new Student { RollNumber = 7, Name = "Hassan Ali", Gender = "Male", DateOfBirth = new DateTime(1991, 11, 30) },
                new Student { RollNumber = 8, Name = "Sana Khan", Gender = "Female", DateOfBirth = new DateTime(1998, 2, 18) },
                new Student { RollNumber = 9, Name = "Imran Qureshi", Gender = "Male", DateOfBirth = new DateTime(1990, 9, 12) },
                new Student { RollNumber = 10, Name = "Zainab Malik", Gender = "Female", DateOfBirth = new DateTime(1999, 4, 22) },
                new Student { RollNumber = 11, Name = "Azhaan Hussain Khan", Gender = "Male", DateOfBirth = new DateTime(2020, 6, 21) },
            };

            return Json(students);
        }
    }
}
