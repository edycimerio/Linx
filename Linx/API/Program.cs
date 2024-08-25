using API.Validadores;
using Domain;
using Domain.Dtos;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Repository;

var builder = WebApplication.CreateBuilder(args);


IConfigurationRoot config = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .AddEnvironmentVariables()
    .Build();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddRespositorys();
builder.Services.AddServices();
builder.Services.AddDbContext<ApplicationDbContext>(options => {options.UseInMemoryDatabase("DespesaDatabase");
});

builder.Services.AddScoped<IValidator<DespesaDto>, PostDespesaValidator>();
builder.Services.AddScoped<IValidator<DespesaDto>, PutDespesaValidator>();
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
