using Microsoft.AspNetCore.Mvc;

namespace LearnASPNET.Controllers
{
    public class NewsController : Controller
    {
        //{year}/{month}/{day}/{contry}/{category}/{slug}
        public IActionResult Visualize(int year, int month, int day, string country, string category, string slug)
        {
            return Ok($"year:{year}, month: {month}, day: {day}, country: {country}, category:{category}, slug:{slug}");
        }
    }
}
