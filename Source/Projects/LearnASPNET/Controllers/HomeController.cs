using Microsoft.AspNetCore.Mvc;

namespace LearnASPNET.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
