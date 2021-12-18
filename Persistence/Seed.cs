using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Activities.Any()) return;

            var activities = new List<Activity>
            {
                new Activity {
                    Name = "Exam",
                    Body = "Project exam",
                },
                new Activity {
                    Name = "Biking",
                    Body = "Nike to home",
                },
                new Activity {
                    Name = "Shopping",
                    Body = "Buying things",
                },
            };

            await context.Activities.AddRangeAsync(activities);
            await context.SaveChangesAsync();
        }
    }
}