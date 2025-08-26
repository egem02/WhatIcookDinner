using Microsoft.EntityFrameworkCore;
using WhatIcookDinner.Models;
using WhatIcookDinner.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddOpenApi();
builder.Services.AddDbContext<ApplicationDbContext>(opt =>
    opt.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=DinnerDb;Trusted_Connection=True;"));


var app = builder.Build();



// Configure the HTTP request pipeline.
app.UseHttpsRedirection();

app.UseAuthorization();
app.MapOpenApi();
app.MapControllers();

app.Run();
