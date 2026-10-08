using Microsoft.AspNetCore.Mvc;
using MyDemoApp.Models;

namespace MyDemoApp.Controllers
{
    public class FormTemplatedFormHelperController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ShowData(Student model)
        {
            return View(model);
        }
    }
}
