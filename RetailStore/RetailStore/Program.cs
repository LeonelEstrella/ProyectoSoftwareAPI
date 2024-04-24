using Application.Interface;
using Application.Interface.Categories;
using Application.Interface.SaleInterface;
using Application.Interface.SaleMaths;
using Application.Interface.SaleProductInterfaces;
using Application.Response;
using Application.UseCase.Categories;
using Application.UseCase.Products;
using Application.UseCase.Sale;
using Application.UseCase.SaleProducts;
using Application.Util;
using Domain.Entities;
using Infraestructure.Command;
using Infraestructure.Persistence;
using Infraestructure.Queries;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Custom
var connectionString = builder.Configuration["ConnectionString"];
builder.Services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(connectionString));
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();

builder.Services.AddScoped<IProductQuery, ProductQuery>();
builder.Services.AddScoped<IProductCommand, ProductCommand>();

builder.Services.AddScoped<ICategoryQuery, CategoryQuery>();

builder.Services.AddScoped<ISaleService, SaleService>();
builder.Services.AddScoped<ISaleQuery, SaleQuery>();
builder.Services.AddScoped<ISaleCommand, SaleCommand>();

builder.Services.AddScoped<ISaleProductService, SaleProductService>();
builder.Services.AddScoped<ISaleProductQuery, SaleProductQuery>();

builder.Services.AddScoped<IList<ProductResponse>, List<ProductResponse>>();
builder.Services.AddScoped<IList<SingleSaleProduct>, List<SingleSaleProduct>>();
builder.Services.AddScoped<ISaleMathematics, SaleMathematics>();
builder.Services.AddScoped<Sale>();

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
