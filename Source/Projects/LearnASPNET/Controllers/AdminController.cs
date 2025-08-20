using Microsoft.AspNetCore.Mvc;

namespace LearnASPNET.Controllers
{
    /// <summary>
     /// /Admin/Dashboard/Home/{id}
     /// </summary>
    [Route("Admin/Dashboard")]
    public class AdminController : Controller
    {
        //[Route("Home/{id:int:range(1, 9999)}")]
        [HttpGet("Home/{id:int:range(1, 9999)}")]
        public IActionResult Index(int id)
        {
            return View();
        }
    }
}
