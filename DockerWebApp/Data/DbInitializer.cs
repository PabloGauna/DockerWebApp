using DockerWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DockerWebApp.Data
{
    public static class DbInitializer
    {
        public static void Initialize(DatabaseContext context)
        {
            context.Database.EnsureCreated();

            // Look for any people.
            if (context.People.Any())
            {
                return;   // DB has been seeded
            }

            var people = new Person[]
            {
                new Person { FirstMidName = "Carson",   LastName = "Alexander" },
                new Person { FirstMidName = "Meredith", LastName = "Alonso" },
                new Person { FirstMidName = "Arturo",   LastName = "Anand" },
                new Person { FirstMidName = "Gytis",    LastName = "Barzdukas" },
                new Person { FirstMidName = "Yan",      LastName = "Li" },
                new Person { FirstMidName = "Peggy",    LastName = "Justice" },
                new Person { FirstMidName = "Laura",    LastName = "Norman" },
                new Person { FirstMidName = "Nino",     LastName = "Olivetto" },
            };

            foreach (Person s in people)
            {
                context.People.Add(s);
            }
            context.SaveChanges();
        }
    }
}
