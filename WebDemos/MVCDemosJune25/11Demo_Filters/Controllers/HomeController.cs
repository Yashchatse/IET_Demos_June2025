using _11Demo_Filters.Filter;
using Microsoft.AspNetCore.Mvc;

namespace _11Demo_Filters.Controllers
{
    //[ServiceFilter(typeof(LoggingActionFilter))]
    [LoggingActionFilter]
    [DynamicLayoutFilter]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
    }
}
