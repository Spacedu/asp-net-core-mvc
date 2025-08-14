using Microsoft.AspNetCore.Mvc;

namespace FirstProject.Controllers;

public class NewsController : Controller
{
    /*
     * CRUD
     */
    public IActionResult Index()
    {
        return Content(
            "<messages><message>Hello World 1!</message><message>Hello World 2!</message></messages>",
            "text/xml"
        );

        return new ContentResult()
        {
            Content = "<messages><message>Hello World!</message><message>Hello World 2!</message></messages>",
            ContentType = "text/xml", //text/plain - text/html - text/xml - application/xml, application/json
            StatusCode = 200
        };
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
