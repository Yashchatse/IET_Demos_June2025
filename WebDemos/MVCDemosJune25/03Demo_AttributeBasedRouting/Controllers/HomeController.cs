using Microsoft.AspNetCore.Mvc;

namespace _03Demo_AttributeBasedRouting.Controllers
{
    [Route("Home")]
    public class HomeController : Controller
    {
        [Route("")]
        //[Route("Home/Index")]
        [Route("Index")]
        [Route("~/")]
        public IActionResult Index()
        {
            return View();
        }

        //[Route("Home/About")]
        [Route("About")]
        public IActionResult About()
        {
            return View();
        }
    }
}
