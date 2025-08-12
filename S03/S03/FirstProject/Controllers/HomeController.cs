using Microsoft.AspNetCore.Mvc;

namespace FirstProject.Controllers;

public class HomeController : Controller
{
    //Razor = Engine Templates
    public IActionResult Index()
    {
        return View();
    }
}
