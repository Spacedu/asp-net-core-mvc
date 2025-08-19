var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//Minimal API (REST)
app.MapGet("/", () => "Hello World!");

app.Run();
