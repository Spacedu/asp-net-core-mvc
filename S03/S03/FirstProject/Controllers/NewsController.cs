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
        /*
         * return Redirect("https://www.google.com");
         * return new RedirectResult("https://www.google.com");
         * 
         * return LocalRedirect("/news/add");
         * return new LocalRedirectResult("/news/add");
         * 
         * /{controller}/{action}/{id?}
         * /{action}/{controller}
        */

        return RedirectToAction("add", "news");
        return new RedirectToActionResult("add", "news", new { }); // Generate URL
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
