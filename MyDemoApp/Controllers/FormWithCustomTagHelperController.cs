using Microsoft.AspNetCore.Mvc;

namespace MyDemoApp.Controllers
{
    public class FormWithCustomTagHelperController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
