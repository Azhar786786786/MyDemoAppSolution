using Microsoft.AspNetCore.Mvc;

namespace MyDemoApp.Controllers
{
    public class FormPassFormCollectionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ShowData(IFormCollection form)
        {
            ViewBag.Name = form["name"];
            ViewBag.FName = form["fname"];
            ViewBag.Gender = form["gender"];
            ViewBag.Dob = form["dob"]; ;
            ViewBag.Dis = form["disability"];
            return View();
        }
    }
}
