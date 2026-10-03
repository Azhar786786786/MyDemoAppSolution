using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyDemoApp.Models;

namespace MyDemoApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}
        public IActionResult Index()
        {
            TempData["Message"] = "This message is from Index Action Method";
            return RedirectToAction("HomePage_ViewData");
            //return RedirectToAction("HomePage_ViewBag");
            //return RedirectToAction("HomePage_TempData");
        }

        public IActionResult HomePage_ViewData()
        {
            ViewData["id"] = "P001";
            ViewData["name"] = "Keyboard";
            ViewData["price"] = 300;
            ViewData["qty"] = 10;
            ViewData["Number1"] = 10;
            ViewData["Number2"] = 20;
            return View();
        }
        public IActionResult HomePage_ViewBag()
        {
            ViewBag.id = "P001";
            ViewBag.name = "Keyboard";
            ViewBag.price = 300;
            ViewBag.qty = 10;
            ViewBag.Number1 = 10;
            ViewBag.Number2 = 20;
            return View();
        }
        public IActionResult Action1()
        {
            TempData["Message"] = "This message is from Action1 Method";
            return RedirectToAction("Action2");
        }
        public IActionResult Action2()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult GetData()
        {
            return Json(new { Name = "Azhar Hussain Khan", Age = 30, Location = "Gorakhpur, Uttar Pradesh, India", Message = "I want to return json data through this action." });
        }
        public IActionResult About()
        {
            return Content("This is my message and i want to return though this action method");
        }
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult Facilities()
        {
            return View();
        }
        public IActionResult Download()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "files", "Resume-AzharHussain.pdf");
            var fileBytes = System.IO.File.ReadAllBytes(filePath);
            return File(fileBytes, "application/pdf", "sample.pdf");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
