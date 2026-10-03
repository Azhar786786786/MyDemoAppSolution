using Microsoft.AspNetCore.Mvc;
using MyDemoApp.Models;

namespace MyDemoApp.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetEmployeeListData()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee { EmployeeId = "EMP001", Name = "Azhar Hussain Khan", Gender = "Male", DateOfBirth = new DateTime(1993, 10, 15) },
                new Employee { EmployeeId = "EMP002", Name = "Mohammed Zubair", Gender = "Male", DateOfBirth = new DateTime(1995, 5, 20) },
                new Employee { EmployeeId = "EMP003", Name = "Shaista Khatoon", Gender = "Female", DateOfBirth = new DateTime(1994, 8, 10) },
                new Employee { EmployeeId = "EMP004", Name = "Ayesha Khan", Gender = "Female", DateOfBirth = new DateTime(1996, 12, 5) },
                new Employee { EmployeeId = "EMP005", Name = "Ali Raza", Gender = "Male", DateOfBirth = new DateTime(1992, 3, 15) },
                new Employee { EmployeeId = "EMP006", Name = "Fatima Zahra", Gender = "Female", DateOfBirth = new DateTime(1997, 7, 25) },
                new Employee { EmployeeId = "EMP007", Name = "Hassan Ali", Gender = "Male", DateOfBirth = new DateTime(1991, 11, 30) },
                new Employee { EmployeeId = "EMP008", Name = "Sana Khan", Gender = "Female", DateOfBirth = new DateTime(1998, 2, 18) },
                new Employee { EmployeeId = "EMP009", Name = "Imran Qureshi", Gender = "Male", DateOfBirth = new DateTime(1990, 9, 12) },
                new Employee { EmployeeId = "EMP0010", Name = "Zainab Malik", Gender = "Female", DateOfBirth = new DateTime(1999, 4, 22) },
                new Employee { EmployeeId = "EMP0011", Name = "Azhaan Hussain Khan", Gender = "Male", DateOfBirth = new DateTime(2020, 6, 21) },
            };

            return View(employees);
        }
    }
}
