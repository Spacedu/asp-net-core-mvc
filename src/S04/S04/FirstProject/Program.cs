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

//Minimal API
app.MapGet("/", () => "Hello World!");

app.Run();
