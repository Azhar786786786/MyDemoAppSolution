using Microsoft.AspNetCore.Mvc;

namespace MyDemoApp.Controllers
{
    public class FormPassDataRequestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ShowData()
        {

            ViewBag.Name = Request.Form["name"];

            ViewBag.FName = Request.Form["fname"];
            ViewBag.Gender = Request.Form["gender"];
            ViewBag.Dob = Request.Form["dob"]; ;
            ViewBag.Dis = Request.Form["disability"];
            return View();
        }
    }
}
