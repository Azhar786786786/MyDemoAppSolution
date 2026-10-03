using Microsoft.AspNetCore.Mvc;
using MyDemoApp.Models;

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
        public IActionResult Details()
        {
            //Intantiating Model
            var products = new List<Product> {
                new Product{Id="P001",ProdName="Keyboard",Price=450,GSTRate=18},
                new Product{Id="P002",ProdName="Mouse",Price=250,GSTRate=18},
                new Product{Id="P003",ProdName="Monitor",Price=4450,GSTRate=18},
            };
            return View(products);
        }
    }
}
