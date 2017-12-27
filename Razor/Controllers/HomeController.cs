using Microsoft.AspNetCore.Mvc;
using Razor.Models;

namespace Razor.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Product[] array =
            {
                new Product {Name = "Kayak", Price = 275M, ProductID = 1 },
                new Product {Name = "Lifejacket", Price = 48.95M, ProductID = 2 },
                new Product {Name = "Football", Price = 19.50M, ProductID = 3 },
                new Product {Name = "Corner flag", Price = 34.95M, ProductID = 4 }
            };

            ViewBag.StockLevel = 2;

            return View(array);
        }
    }
}
