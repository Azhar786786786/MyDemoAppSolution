using Microsoft.AspNetCore.Mvc;

namespace MyDemoApp.Controllers
{
    public class FormPassDataParameterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ShowData(string name, string fname, string gender, string dob, string disability)
        {
            ViewBag.Name = name;
            ViewBag.FName = fname;
            ViewBag.Gender = gender;
            ViewBag.Dob = dob;
            ViewBag.Dis = disability;
            return View();
        }
    }
}
