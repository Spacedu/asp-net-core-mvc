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
        return View("Add");
        return View();
        return new ViewResult() { ViewName = "Index", ContentType = "text/html", StatusCode = 200 };
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
