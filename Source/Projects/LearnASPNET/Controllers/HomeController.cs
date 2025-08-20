using Microsoft.AspNetCore.Mvc;

namespace LearnASPNET.Controllers
{
    
    public class HomeController : Controller
    {
        
        public IActionResult Index(int id)
        {
            return View();
        }

        public IActionResult ContentView()
        {
            return Content("Hello <strong>World!</strong>", "text/html");

            return new ContentResult()
            {
                Content = "Hello world!",
                ContentType = "text/plain",
                StatusCode = 200
            };
        }

        public IActionResult JsonView()
        {
            var user = new { name = "Jhon", age = 20 };

            return Ok(user);
            return Json(user);
            return new JsonResult(user);
        }

        public IActionResult FileView()
        {
            //wwwroot
            //return new VirtualFileResult("pdfs/news1.pdf", "application/pdf");

            //return new PhysicalFileResult(@"C:\Dev\asp-net-core-mvc\Materials\S03\payment.pdf", "application/pdf");

            var bytes = System.IO.File.ReadAllBytes(@"C:\Dev\asp-net-core-mvc\Source\Projects\LearnASPNET\wwwroot\pdfs\home.pdf");
            return new FileContentResult(bytes, "application/pdf");
        }
        public IActionResult ViewView()
        {
            return View("Index");
            return new ViewResult() { StatusCode = 200, ViewName = "ViewView", ContentType = "text/html" };
        }
    }
}
