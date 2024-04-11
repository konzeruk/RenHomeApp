using ApplicationContextDB.Contexts;
using EntitiesRepositories;
using HomeStorageService.Controllers;

var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;

services.AddControllers();

services.AddSingleton<ILogger>(s => s.GetService<ILogger<HomeStorageController>>()!);
services.AddScoped<ContextHomeDB>();
services.AddScoped<HomeEntityRepository>();

var app = builder.Build();

builder.Configuration.AddJsonFile("appsettings.json");

app.MapControllers();

app.Run();
