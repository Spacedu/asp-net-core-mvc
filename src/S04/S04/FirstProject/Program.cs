/*
 * Program.cs + Startup.cs
 * ASP.NET Core <5.0:
 * - Startup.cs:
 * -- ConfigureService = Add Services(Database, Queue, DI.....)
 * -- Configure = Pipeline
 * ASP.NET Core 5.0:
 * - builder.Services = ConfigureService
 * - app = Configure
 */

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Run(async(HttpContext context) => {
    //Request: Address, Method, Headers, Body
    //Response: Status Code, Header, Body
    if(context.Request.Path.ToString()== "/contact")
    {
        await context.Response.WriteAsync("Contact Page!");
    }
    else {
        context.Response.StatusCode = 201;
        await context.Response.WriteAsync("Hello World! 2025");
    }
});

app.Run();
