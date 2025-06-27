using Microsoft.AspNetCore.Mvc;

namespace _04Demo_ReturnTypesOfActionMethods.Controllers
{
    public class HomeController : Controller
    {
        //Most Flexible ReturnType - can return almost anything 
        public IActionResult Index()
        {
            return View();
        }
        public ViewResult M1()
        {
            return View("~/Views/Home/Index.cshtml");
        }
        // Non- generic ActionResult
        public ActionResult M2()
        {
            return View("~/Views/Home/Index.cshtml");
        }
        //genetric/ non-generic types of ActionResult
        // If this is a Generic Type : it means : This is a combination of : IActionResult and strongly-typed responses
        // /Home/GetUserCredentials?un=admin&pw=1234
        public ActionResult<string> GetUserCredentials(string un, string pw)
        {
            return $"User = {un}, Password = {pw}";
            //return View("~/Views/Home/Index.cshtml");
        }
        public int About()
        {
            return 100;
        }
        public JsonResult GetJSONData()
        {
            var data = new
            {
                CompanyName = "BVS",
                Address = "Pune",
                Courses = new[] { "React", "Asp.Net MVC Core", "Python", "C#" }
            };
            return Json(data);
        }
        public StatusCodeResult GetStatusCode()
        {
            return StatusCode(404);
        }

        public ObjectResult GetSomeObject()
        {
            var obj = new { Name = "Harry Potter", Address = "Hogwarts" };
            return new ObjectResult(obj);
        }
        public EmptyResult DoNothing()
        {
            return new EmptyResult();
        }

        [HttpGet("Home/GetDataAsunc")]
        public async Task<IActionResult> GetDataAsunc()
        {
            await Task.Delay(4000);
            return View("~/Views/Home/GetData.cshtml");
        }

        public FileResult DownloadFile()
        {
            var byteArray = System.IO.File.ReadAllBytes(@"D:\Personal\IETCDAC\June25\WebDemos\MVCDemosJune25\04Demo_ReturnTypesOfActionMethods\Data\quote.pdf");

            return File(byteArray, "application/pdf", "quote.pdf");
        }
    }
}
