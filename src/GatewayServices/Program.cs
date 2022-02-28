using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddJsonFile("config.json", optional: false, reloadOnChange: true).AddEnvironmentVariables();
builder.Services.AddOcelot();
var app = builder.Build();

await app.UseOcelot();

app.Run();
