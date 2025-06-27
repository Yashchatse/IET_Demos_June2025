using Microsoft.AspNetCore.Mvc;

namespace _05Demo_ViewBag_ViewData_TempData.Controllers
{
    public class HomeController : Controller
    {
        string[] fruits = new string[] { "Apple", "Banana", "Cherry" };
        public IActionResult Index()
        {
            ViewBag.Fruits = fruits;
            ViewBag.Name = "Hugh Jackman";
            //return View(fruits);
            TempData["Message"] = "Welcome to the Home Page!";
            return View();
        }

        public IActionResult About()
        {
            ViewData["numbers"] = new int[] { 1, 2, 3, 4, 5 };
            ViewBag.Name = "Hugh Grant";
            return View(fruits);
        }
        public IActionResult Contact()
        {
            return View();
        }
    }
}
