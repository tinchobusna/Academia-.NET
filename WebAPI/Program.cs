using WebAPI.EndPoints;
using Data;
using ProfesorCursoAPI.EndPoints;
using Domain.Model;
using Application.Services;
using DTOs;
using EspecialidadAPI.EndPoints;
using MateriaAPI.EndPoints;
using Microsoft.AspNetCore.OpenApi;
using Microsoft.EntityFrameworkCore;
using QuestPDF.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<TPIContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);

QuestPDF.Settings.License = LicenseType.Community;

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpLogging(o => { });

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowBlazorClient", policy =>
    {
        policy.WithOrigins("http://localhost:5210", "https://localhost:7254")
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

builder.WebHost.UseUrls(
    "http://localhost:5039",
    "https://localhost:7048"
);

var app = builder.Build();

// Inicializa la base de datos si no existe
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<TPIContext>();
    context.Database.EnsureCreated();
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseHttpLogging();
}

app.UseCors("AllowBlazorClient");

app.MapCursoEndpoints();
app.MapUsuarioEndpoints();
app.MapMateriaEndpoints();
app.MapPersonaEndpoints();
app.MapComisionEndpoints();
app.MapPlanEndpoints();
app.MapEspecialidadEndpoints();
app.MapAlumnoInscripcionEndpoints();
app.MapProfesorCursoEndpoints();
app.MapReporteEndpoints();

app.Run();