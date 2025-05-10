using System;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using TransactionMonitoring.Application.Interface;
using TransactionMonitoring.Domain;
using TransactionMonitoring.Infrastructure.Repositories;
using TransactionMonitoring.Infrastructure.UnitOfWorks;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IUnitOfWork>(provider =>
{
    var config = provider.GetRequiredService<IConfiguration>();
    var providerType = config["Database:Provider"];

    switch (providerType.Trim().ToLower())
    {
        case "mongo":
            var mongoClient = new MongoClient(config["Mongo:ConnectionString"]);
            var mongoDb = mongoClient.GetDatabase(config["Mongo:DatabaseName"]);
            return new MongoUnitOfWork(mongoDb);

        case "sql":
            var dbContext = provider.GetRequiredService<AppDbContext>();
            return new EfUnitOfWork(dbContext);

        default:
            var defaultDbContext = provider.GetRequiredService<AppDbContext>();
            return new EfUnitOfWork(defaultDbContext);
    }

});

// If using SQL, also register DbContext
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

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

