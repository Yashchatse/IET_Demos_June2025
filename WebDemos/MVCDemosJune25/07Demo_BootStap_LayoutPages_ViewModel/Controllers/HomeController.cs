using _07Demo_BootStap_LayoutPages_ViewModel.Models;
using Microsoft.AspNetCore.Mvc;

namespace _07Demo_BootStap_LayoutPages_ViewModel.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var emps = GetAllEmployees();
            var depts = GetAllDepts();
            EmpViewModel empViewModel = new EmpViewModel
            {
                allEmployees = emps, //db.emps.ToList();
                allDepartments = depts // db.dpets.ToList()
            };
            return View(empViewModel);
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public List<Emp> GetAllEmployees()
        {
            return new List<Emp> {
                new Emp(){ EId = 1, EName = "Hugh", Dept = new Dept(){ deptId = 1, deptName = "HR"} , EDescription ="HR Manager" },
                new Emp(){ EId = 2, EName = "Jack", Dept = new Dept(){ deptId = 2, deptName = "Sales"} , EDescription ="Sales Manager" },
                new Emp(){ EId = 3, EName = "Tom", Dept = new Dept(){ deptId = 3, deptName = "IT"} , EDescription ="Corporate Trainer" }
            };
        }

        public List<Dept> GetAllDepts()
        {
            return new List<Dept>
            {
                new Dept(){deptId = 1, deptName = "HR" },
                new Dept(){ deptId = 2, deptName = "Sales"},
                new Dept(){ deptId = 3, deptName = "IT"}
            };
        }
    }
}
