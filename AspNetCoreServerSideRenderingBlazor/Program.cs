using AspNetCoreServerSideRenderingBlazor;
using Microsoft.AspNetCore.Components.Endpoints;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents();

var app = builder.Build();

app.MapRazorComponents<ServerSideApp>();

app.MapGet("/my", () => new RazorComponentResult<ServerSideApp>()); // alternate to map Razor component endpoint

app.Run();
