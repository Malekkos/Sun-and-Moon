using Microsoft.EntityFrameworkCore;
using Book.Models;


var builder = WebApplication.CreateBuilder(args);

// getting a connection string.
var connectionString = builder.Configuration.GetConnectionString("SampleDbConnection");



// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEntityFrameworkNpgsql().AddDbContext<BookContext>(opt =>
    opt.UseNpgsql(connectionString));
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
