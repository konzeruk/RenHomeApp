using ApplicationContextDB.Contexts;
using EntitiesRepositories;
using ReviewService.Controllers;

var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;

services.AddControllers();

services.AddSingleton<ILogger>(s => s.GetService<ILogger<ReviewController>>()!);
services.AddScoped<ContextReviewDB>();
services.AddScoped<ReviewEntityRepository>();

var app = builder.Build();

builder.Configuration.AddJsonFile("appsettings.json");

app.MapControllers();

app.Run();
