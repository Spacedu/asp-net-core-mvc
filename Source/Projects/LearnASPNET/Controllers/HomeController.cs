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
    }
}
