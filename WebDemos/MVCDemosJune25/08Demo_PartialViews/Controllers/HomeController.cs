using System.Diagnostics;
using _08Demo_PartialViews.Models;
using Microsoft.AspNetCore.Mvc;

namespace _08Demo_PartialViews.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            List<Emp> emps = new List<Emp>() {
                new Emp(){ Id = 11, Name = "Hugh Jackman", Dept = "IT"},
                new Emp(){ Id = 11, Name = "Hugh Grant", Dept = "HR"},
                new Emp(){ Id = 11, Name = "Jack Black", Dept = "Sales"},
                new Emp(){ Id = 11, Name = "Ben Stiller", Dept = "Admin"}
            };
            return View(emps);
        }
        public IActionResult ProductData()
        {
            List<Product> products = new List<Product>() {
                new Product(){ Id = 1, Name = "Laptop", Price = 75000, Description = "Asus 16GB RAM", Image="~/images/img32.jpg"},
                new Product(){ Id = 2, Name = "HDD", Price = 5000, Description = "Sandisk 1TB", Image="~/images/img33.jpg"},
                new Product(){ Id = 3, Name = "Mobile", Price = 175000, Description = "Nokia, Windows OS", Image="~/images/img35.jpg"},
            };
            return View(products);
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
