using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Commander.Data;

namespace Commander.Models
{
    public static class PrepDb
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using(var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<CommanderContext>());
            }
        }

        public static void SeedData(CommanderContext Context)
        {
            System.Console.WriteLine("Applying Migrations...");

            Context.Database.Migrate();

            if(!Context.Commands.Any())
            {
                System.Console.WriteLine("Seeding data...");

                Context.Commands.AddRange(                 
                    new Command() { HowTo = "HowTo1", Line = "Line1", Platform = "Platform1"},
                    new Command() { HowTo = "HowTo2", Line = "Line2", Platform = "Platform2" },
                    new Command() { HowTo = "HowTo3", Line = "Line3", Platform = "Platform3" }
                );

                Context.SaveChanges();
            }
            else
            {
                System.Console.WriteLine("Data already exists. Skip Seeding data...");
            }

        }
    }
}
