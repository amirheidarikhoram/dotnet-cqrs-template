using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Identity;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context, UserManager<AppUser> userManager)
        {

            if (!context.Users.Any())
            {
                var users = new List<AppUser> {
                    new AppUser {UserName = "amir", DisplayName = "Amir Heidari", Email = "amir@test.ir"},
                    new AppUser {UserName = "ali", DisplayName = "Ali Jabbar", Email = "ali@test.ir"},
                    new AppUser {UserName = "banan", DisplayName = "Banan Kiamanesh", Email = "banan@test.ir"},
                    new AppUser {UserName = "sobhan", DisplayName = "Sobhan Shokueian", Email = "sobhan@test.ir"},
                };

                foreach (var user in users)
                {
                    await userManager.CreateAsync(user, "Pa$$w0rd");
                }
            }

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