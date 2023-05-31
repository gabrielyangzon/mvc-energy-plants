using Microsoft.EntityFrameworkCore;

namespace mvc_energy_plants.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new energy_plantsContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<energy_plantsContext>>()))
            {
                if (context == null || context.Project == null)
                {
                    throw new ArgumentNullException("Null RazorPagesProjectContext");
                }

                // Look for any Projects.
                if (context.Project.Any())
                {
                    return;   // DB has been seeded
                }

                context.Project.AddRange(
                    new Project
                    {
                        Name = "PH Test Project 1",
                        Code = "PH1",
                        CustomerName = "Ayala Group",
                        Country = "PH",
                        PowerGeneration = 150,
                        Longitude = 0,
                        Latitude = 0,
                        StartDate = DateTime.Parse("1990-2-12")
                    },

                    new Project
                    {
                        Name = "PH Test Project 2",
                        Code = "PH2",
                        CustomerName = "SM Investments",
                        Country = "PH",
                        PowerGeneration = 200,
                        Longitude = 0,
                        Latitude = 0,
                        StartDate = DateTime.Parse("1999-5-23")
                    },

                    new Project
                    {
                        Name = "PH Test Project 3",
                        Code = "PH3",
                        CustomerName = "LT Group",
                        Country = "PH",
                        PowerGeneration = 350,
                        Longitude = 0,
                        Latitude = 0,
                        StartDate = DateTime.Parse("2005-3-12")
                    },

                    new Project
                    {
                        Name = "PH Test Project 4",
                        Code = "PH4",
                        CustomerName = "MPIC",
                        Country = "PH",
                        PowerGeneration = 500,
                        Longitude = 0,
                        Latitude = 0,
                        StartDate = DateTime.Parse("2020-12-12")
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
