using foodapi.Data;
using foodapi.Repositories;
using foodapi.Repositories.Impl;
using foodapi.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// DI for Repository
builder.Services.AddScoped<IFoodRepo, FoodRepoImpl>();
builder.Services.AddScoped<ICustomerRepo, CustomerRepoImpl>();

// DI for Serivice
builder.Services.AddScoped<IFoodService, FoodServiceImpl>();
builder.Services.AddScoped<ICustomerService, CustomerServiceImpl>();

builder.Services.AddDbContext<ApplicationDbContext>(options => {
    options.UseMySQL(builder.Configuration.GetConnectionString("MysqlDefaultConnection"));
});

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
