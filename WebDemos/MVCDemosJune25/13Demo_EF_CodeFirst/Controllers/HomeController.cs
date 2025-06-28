using System.Diagnostics;
using _13Demo_EF_CodeFirst.Models;
using Microsoft.AspNetCore.Mvc;

namespace _13Demo_EF_CodeFirst.Controllers
{
    public class HomeController : Controller
    {
        private readonly EmpDbContext _dbContext;

        public HomeController(EmpDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var allEmployees = _dbContext.emps.ToList(); 
            return View(allEmployees);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Emp emp)
        {
            _dbContext.emps.Add(emp);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
            
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
