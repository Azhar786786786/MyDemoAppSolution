using Microsoft.AspNetCore.Mvc;

namespace MyDemoApp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            ViewData["id"] = "P001";
            ViewData["name"] = "Keyboard";
            ViewData["price"] = 300;
            ViewData["qty"] = 30;
            return View();
        }
    }
}
