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



app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();




