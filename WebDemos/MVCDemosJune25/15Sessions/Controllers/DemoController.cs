using Microsoft.AspNetCore.Mvc;

namespace _15Sessions.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Welcome Home - Index";
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Title = "This is about us !";
            return View();
        }
    }
}

