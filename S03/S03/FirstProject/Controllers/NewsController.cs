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
        //return new VirtualFileResult("images/cover.jpg", "image/jpg");
        //return new PhysicalFileResult(@"C:\Users\elias\OneDrive\Pictures\Wallpaper\Abstract\8894463.jpg", "image/jpg");

        var byteArray = System.IO.File.ReadAllBytes(@"C:\Users\elias\OneDrive\Pictures\Wallpaper\Abstract\bigsur.jpg");
        return new FileContentResult(byteArray, "image/jpg");
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
