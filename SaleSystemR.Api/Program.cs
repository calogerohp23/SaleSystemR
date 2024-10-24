using Microsoft.EntityFrameworkCore;
using SaleSystemR.Persistence.Context;
using SaleSystemR.Persistence.Interfaces;
using SaleSystemR.Persistence.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<SaleSystemRContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("SaleSystemRDB")));

//dependecies registry

builder.Services.AddScoped<IArticulosRepository, ArticuloRepository>();
builder.Services.AddScoped<ICompaniaRepository, CompaniaRepository>();
b

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
