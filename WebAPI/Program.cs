using Application.Services;
using Domain.Model;
using DTOs;
using WebAPI.EndPoints;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen();
builder.Services.AddHttpLogging(o => { });
    
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // app.UseSwagger();
    app.UseSwaggerUI();
    app.UseHttpLogging();
}

app.UseHttpsRedirection();


app.MapCursoEndpoints();
app.MapUsuarioEndpoints();
app.MapMateriaEndpoints();
app.MapPersonaEndpoints();
app.MapComisionEndpoints();


app.Run();
