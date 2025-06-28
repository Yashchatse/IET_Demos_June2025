using System.Diagnostics;
using _09Demo_ProductViewModel.Models;
using Microsoft.AspNetCore.Mvc;

namespace _09Demo_ProductViewModel.Controllers
{
    public class HomeController : Controller
    {
        private Product _product = new Product()
        {
            Id = 1,
            Name = "Asus Laptop",
            Price = 75000
        };
        public IActionResult Index()
        {
            ProductViewModel productViewModel = new ProductViewModel()
            {
                Product = _product,
                CategoryName = "Electronics",
                isInStock = true,
                Message = "This is a high-performance laptop suitable for gaming and professional work."
            };
            return View(productViewModel);
        }
        public IActionResult ProductDeatils(int id)
        {
            int Id = id;
            return View(_product);
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
