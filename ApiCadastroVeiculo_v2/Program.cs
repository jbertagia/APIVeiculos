using ApiCadastrarVeiculo.Data;
using ApiCadastrarVeiculo.Rotas;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<VeiculoContext>(opt =>
    opt.UseSqlite("Data Source=veiculos.db"));

var app = builder.Build();

app.MapGet("/", () => "Para listar os veículos acessar o localhost em /api/veiculos");
app.MapGetRoutes();
app.MapPostRoutes();
app.MapDeleteRoutes(); 

app.Run();
