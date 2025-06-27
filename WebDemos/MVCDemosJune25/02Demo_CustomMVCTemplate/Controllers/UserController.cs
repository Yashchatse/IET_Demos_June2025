using Microsoft.AspNetCore.Mvc;

namespace _02Demo_CustomMVCTemplate.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
