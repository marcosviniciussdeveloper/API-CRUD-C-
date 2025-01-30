using ApiCrud.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiCrud.Data;


public class PersonContext : DbContext
{
    public DbSet<PersonModel> People { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(connectionString: "Data Source = person.SqLite");
        base.OnConfiguring(optionsBuilder);
    }
   
}

