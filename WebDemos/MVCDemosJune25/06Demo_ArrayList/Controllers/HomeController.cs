using System.Collections;
using System.Diagnostics;
using _06Demo_ArrayList.Models;
using Microsoft.AspNetCore.Mvc;

namespace _06Demo_ArrayList.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ArrayList arr = new ArrayList()
            {
                new Emp(){ Id = 11, Name= "Hugh Jackman", Address ="NYC"},
                new Cust(){  CId = 101, CName = "John Doe", CBNo = 123456 },
            };
            return View(arr);
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
