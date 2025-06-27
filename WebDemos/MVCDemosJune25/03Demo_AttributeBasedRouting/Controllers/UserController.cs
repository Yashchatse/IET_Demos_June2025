using Microsoft.AspNetCore.Mvc;

namespace _03Demo_AttributeBasedRouting.Controllers
{
    [Route("[controller]")] // Token based routing
    public class UserController : Controller
    {
        //[Route("[controller]/[action]")]
        [Route("[action]")]
        public IActionResult Index()
        {
            return View();
        }

        //[Route("[controller]/[action]")]
        [Route("[action]/{id?}")]
        public int About(int? id)
        {
            // ?? and ??=
            return id ?? 555; // Null Coalescing Operator if id  == null then return 555 or return id value as it is.
        }
    }
}
