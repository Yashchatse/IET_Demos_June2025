using Microsoft.AspNetCore.Mvc;

namespace _03Demo_AttributeBasedRouting.Controllers
{
    //Routes are customized using attributes
    //This is the base route for this controller
    // We can have multiple routes for the same action method
    // The first route is the default route
    // Route names and controller and action method names could be different

    [Route("Manager")]
    public class AdminController : Controller
    {
        [Route("Emp")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("Dashboard")]
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
