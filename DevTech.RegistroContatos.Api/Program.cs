using DevTech.RegistroContatos.Dados.Contextos;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<Contexto>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("dev")));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
