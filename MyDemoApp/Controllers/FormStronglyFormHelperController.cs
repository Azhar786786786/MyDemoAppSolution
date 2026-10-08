using Microsoft.AspNetCore.Mvc;
using MyDemoApp.Models;

namespace MyDemoApp.Controllers
{
    public class FormStronglyFormHelperController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ShowData(Employee model)
        {
            return View(model);
        }
    }
}
