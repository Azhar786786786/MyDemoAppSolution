using Microsoft.AspNetCore.Mvc;

namespace MyDemoApp.Controllers
{
    public class TemporaryDataController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Action1(string firstNumber, string secondNumber)
        {
            int num1 = Convert.ToInt32(firstNumber);
            int num2 = Convert.ToInt32(secondNumber);
            int res = num1 + num2;
            TempData["Result"] = res;
            return RedirectToAction("Action2");
        }
        public IActionResult Action2()
        {
            return View();
        }
        public IActionResult Action3()
        {
            return View();
        }
    }
}
