using FirstProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstProject.Controllers;

public class NewsController : Controller
{
    /*
     * CRUD
     */
    public IActionResult Index()
    {
        var news = new News { Id =1, Title = "Title 1", Text = "Text 1" };
        return Json(news);
    }
    public IActionResult Add()
    {
        return View();
    }
    public IActionResult Edit()
    {
        return View();
    }
    public IActionResult Delete()
    {
        return Ok("Removed");
    }

    /* Client View News */
    public IActionResult Visualize(int year, int month, int day, string country, string category, string slug)
    {
        return Ok(new { year, month, day, country, category, slug });
        return View();
    }
}
