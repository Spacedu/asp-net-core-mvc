var builder = WebApplication.CreateBuilder(args);
/*
 * MVC, Blazor Server, RazorPages, Database, Architecture (DI), Smtp...
 * builder.Services.Add
 */

var app = builder.Build();
/*
 * Pipeline
 */

/*
 * Middleware
 * - context: Request + Response
 * - next: > Next Middleware
 */

app.Run(async (context) => {
    context.Response.ContentType = "text/html";
    if (context.Request.Path == "/contact")
    {
        await context.Response.WriteAsync("This is the contact page.");
    }
    await context.Response.WriteAsync("<strong>Copyright &copy; </strong>Spacedu");    
});
app.Run();