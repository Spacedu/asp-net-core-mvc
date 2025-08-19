var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//ASP.NET Core (+MVC)
app.Run(async context => {
    if(context.Request.Method == "GET" && context.Request.Path == "/contact")
    {
        context.Response.StatusCode = 200;
        context.Response.ContentType = "text/html";
        await context.Response.WriteAsync("<h1>Contact</h1> - Method: GET");
    }
    else
    {
        context.Response.StatusCode = 404;
        await context.Response.WriteAsync("Not Found");
    }
});

app.Run();
