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

//Middleware 1
app.Use(async (context, next) => {
    await context.Response.WriteAsync("Start - Middleware 1!");
    await next.Invoke();
    await context.Response.WriteAsync("End - Middleware 1!");
});

//Middleware 2
app.Use(async (context, next) => {
    await context.Response.WriteAsync("Start - Middleware 2!");
    await next.Invoke();
    await context.Response.WriteAsync("End - Middleware 2!");
});

app.Run();