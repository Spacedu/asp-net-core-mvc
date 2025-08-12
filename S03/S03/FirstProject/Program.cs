var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var app = builder.Build();
app.UseStaticFiles();
app.UseRouting();

//www.yousite.com.br/{controller}/{action}/{id?}


//www.yousite.com.br/
//www.yousite.com.br/Home
//www.yousite.com.br/Home/Index

//CRUD
//www.yousite.com/News -> www.yousite.com/News/Index
//www.yousite.com/News/Index
//www.yousite.com/News/Add
//www.yousite.com/News/Edit/1
//www.yousite.com/News/Delete/10

//www.yousite.com/{year}/{month}/{day}/{contry}/{category}/{slug}


app.MapControllerRoute(
    name: "news",
    pattern: "{year:int:min(1900)}/{month:int:range(1,12)}/{day:int:range(1,31)}/{country}/{category}/{*slug}",
    defaults: new { controller="News", action= "Visualize" }
);
app.MapControllerRoute(
    name:"default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);


app.Run();