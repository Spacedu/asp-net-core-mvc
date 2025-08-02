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
 */

app.UseRouting();
app.MapControllerRoute(
    name:"default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();