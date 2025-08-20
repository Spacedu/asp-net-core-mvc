var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

#region News Route
/*
 CRUD:
 - https://yoursite.com/Product/ (List)
 - https://yoursite.com/Product/Add
 - https://yoursite.com/Product/Edit/1

 - https://www.nytimes.com/2025/08/19/us/politics/trump-summits-putin-zelensky.html
 */
app.MapControllerRoute(
    name: "news",
    pattern: "{year:int}/{month:int}/{day:int}/{country}/{category}/{*slug}",
    defaults: new { controller = "News", action="Visualize"}
);
#endregion

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.UseStaticFiles();

app.Run();
