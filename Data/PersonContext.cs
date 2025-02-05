using ApiCrud.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Npgsql.EntityFrameworkCore.PostgreSQL;

namespace ApiCrud.Data
{
    public class PersonContext : DbContext
    {
        public DbSet<PersonModel> People { get; set; }

        public PersonContext(DbContextOptions<PersonContext> options) : base(options) { }

    }
}
       