using Microsoft.AspNetCore.Mvc;
using MyDemoApp.Models;

namespace MyDemoApp.Controllers
{
    public class FormValidationSimpleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                // Process the valid user data (e.g., save to database)
                return RedirectToAction("Success");
            }
            else
            {
                // Return the view with validation errors
                return View(user);
            }
        }
    }
}
