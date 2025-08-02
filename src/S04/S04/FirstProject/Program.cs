var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

/*
 * Path = /{controller}/{action}/{id?}
 * https://www.yousite.com/users/register
 * https://www.yousite.com/users/edit/1 
 * 
 * 
 * https://www.youblog.com/
 * https://www.youblog.com/news/{slug}
 * https://www.youblog.com/news/car-crash
 * 
 * https://www.youblog.com/news
 * 
 * wwwroot/images/1.jpg (Headers: E-Tag - Zip)
 * https://www.youblog.com/images/1.jpg
 */

/*
 * ASP.NET Core < 9.0
 * - UseStaticFiles
 * 
 * ASP.NET Core >9.0
 * - MapStaticAssets
 */

app.MapStaticAssets();

app.UseRouting();
app.MapControllerRoute(
    name:"default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();