using CleanArchitectureRetoUno.Application.Interfaces;
using CleanArchitectureRetoUno.Application.Services;
using CleanArchitectureRetoUno.Domain.Interfaces;
using CleanArchitectureRetoUno.Infrastructure.Repositories;
using Microsoft.OpenApi.Models;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// Registra los servicios de aplicación
builder.Services.AddScoped<ICartService, CartService>();

// Registra los repositorios
builder.Services.AddScoped<ICartRepository, CartRepository>();

// Configura Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "CleanArchitectureRetoUno.API", Version = "v1" });
});
// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi


var app = builder.Build();


// Configura el pipeline de solicitudes HTTP.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CleanArchitecture.API v1"));
}

//app.UseHttpsRedirection();

// var summaries = new[]
// {
//     "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
// };

// app.MapGet("/weatherforecast", () =>
// {
//     var forecast =  Enumerable.Range(1, 5).Select(index =>
//         new WeatherForecast
//         (
//             DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
//             Random.Shared.Next(-20, 55),
//             summaries[Random.Shared.Next(summaries.Length)]
//         ))
//         .ToArray();
//     return forecast;
// })
// .WithName("GetWeatherForecast");

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();

//record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
//{
  //  public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
//}


