using Microsoft.AspNetCore.Mvc;

namespace MyDemoApp.Controllers
{
    public class FormWithCustomTagHelperHTMLController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
