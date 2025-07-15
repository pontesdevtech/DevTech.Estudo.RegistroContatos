using DevTech.RegistroContatos.Api.Endpoints;
using DevTech.RegistroContatos.Dados.Contextos;
using DevTech.RegistroContatos.Dados.Repositorios;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// DbContext
builder.Services.AddDbContext<Contexto>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("dev")));
builder.Services.AddScoped<PessoaRepositorio>();

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.MapPessoaEndpoints();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.Run();
