using Microsoft.AspNetCore.Mvc;

namespace _02Demo_CustomMVCTemplate.Controllers
{
    public class HomeController : Controller
    {
        //Action Method
        public IActionResult Index()
        {
            return View();
        }
    }
}
