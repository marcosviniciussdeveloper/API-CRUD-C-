using ApiCrud.Data;
using ApiCrud.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.Configuration;
using Npgsql.EntityFrameworkCore.PostgreSQL;
namespace ApiCrud.Routes;


public static class PersonRoute
{


    public static void PersonRoutes(this WebApplication app)
    {
        var route = app.MapGroup(prefix: "person");
        route.MapPost(pattern: "", async (PersonRequest req, PersonContext context) =>
        {

            var person = new PersonModel(req.name);
            await context.AddAsync(person);
            await context.SaveChangesAsync();
        });

        route.MapGet("", async (PersonContext context) =>
            {
                var people = await context.People.ToListAsync();
                return Results.Ok(people);
            });

        route.MapPut(pattern: "{id:guid}",
            async (Guid id, PersonRequest req, PersonContext context, CancellationToken ct) =>
          {
              var person = await context.People.FirstOrDefaultAsync(p => p.Id == id);

              if (person == null)
                  return Results.NotFound(null);

              person.ChangenName(req.name);
              await context.SaveChangesAsync();

              return Results.Ok(person);
          });

        route.MapDelete(pattern: "{id:guid}",
         async (Guid id, PersonContext context) =>
        {
            var person = await context.People.FirstOrDefaultAsync(p => p.Id == id);

            if (person == null)
                return Results.NotFound(null);

            person.SetInactive();
            await context.SaveChangesAsync();

            return Results.Ok(new { message = "Usuario desativado com sucesso", person });
        });
    }
}



