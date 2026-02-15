using H.DataAccess;
using H.DataAccess.Infrastructure;
using H.DataAccess.UnitofWork;
using Microsoft.AspNetCore.Connections;
using Microsoft.EntityFrameworkCore;

using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Registro de servicios
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

// Configuración de CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("UI-FrontEnd", policy =>
    {
        policy.WithOrigins("http://localhost:4200")
              .AllowAnyHeader()
        .AllowAnyMethod();
    });
});

// Registrar servicios
builder.Services.AddScoped<H.DataAccess.Infrastructure.IConnectionFactory>(
    provider => new ConnectionFactory(
        builder.Configuration.GetConnectionString("DefaultConnection"))
);

builder.Services.AddDbContext<sistemContext>(
    opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
