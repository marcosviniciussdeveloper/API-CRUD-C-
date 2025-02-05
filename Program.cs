using Microsoft.EntityFrameworkCore;
using ApiCrud.Data;
using ApiCrud.Routes;

var builder = WebApplication.CreateBuilder(args);

var connectionString = Environment.GetEnvironmentVariable("DATABASE_URL")
                      ?? builder.Configuration.GetConnectionString("DefaultConnection");


builder.Services.AddDbContext<PersonContext>(options =>
    options.UseNpgsql(connectionString));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseAuthorization();
app.MapControllers();

app.PersonRoutes();

app.Run();
