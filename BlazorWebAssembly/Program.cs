/*
using BlazorWebAssembly;
using BlazorWebAssembly.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Configure HttpClient for API calls
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5039/") });

// Add authentication state service
builder.Services.AddScoped<AuthenticationStateService>();

await builder.Build().RunAsync();
*/
using BlazorWebAssembly;
using BlazorWebAssembly.Services;
using Microsoft.EntityFrameworkCore;
using System;
using Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddDbContext<TPIContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<AuthenticationStateService>();

var app = builder.Build();

app.MapRazorComponents<App>().AddInteractiveServerRenderMode();

app.Run();
