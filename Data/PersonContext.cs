using ApiCrud.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiCrud.Data;


public class PersonContext : DbContext
{
    public DbSet<PersonModel> People { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = Environment.GetEnvironmentVariable("DATAVASE_URL") ?? "Data Source =person.Sqlite";
        optionsBuilder.UseSqlite(connectionString);
    }
   
}

