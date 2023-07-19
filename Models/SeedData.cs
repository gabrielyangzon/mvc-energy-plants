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

                context.Database.EnsureCreated();
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
                    },
                      new Project
                      {
                          Name = "SG Test Project 1",
                          Code = "SG1",
                          CustomerName = "Grab",
                          Country = "SG",
                          PowerGeneration = 200,
                          Longitude = 0,
                          Latitude = 0,
                          StartDate = DateTime.Parse("2020-12-12")
                      },
                       new Project
                       {
                           Name = "SG Test Project 2",
                           Code = "SG2",
                           CustomerName = "Grab",
                           Country = "SG",
                           PowerGeneration = 150,
                           Longitude = 0,
                           Latitude = 0,
                           StartDate = DateTime.Parse("2020-12-12")
                       },
                          new Project
                          {
                              Name = "SG Test Project 3",
                              Code = "SG3",
                              CustomerName = "Grab",
                              Country = "SG",
                              PowerGeneration = 300,
                              Longitude = 0,
                              Latitude = 0,
                              StartDate = DateTime.Parse("2020-12-12")
                          },
                           new Project
                           {
                               Name = "SG Test Project 4",
                               Code = "SG4",
                               CustomerName = "Grab",
                               Country = "SG",
                               PowerGeneration = 300,
                               Longitude = 0,
                               Latitude = 0,
                               StartDate = DateTime.Parse("2020-12-12")
                           },
                            new Project
                            {
                                Name = "SG Test Project 4",
                                Code = "SG4",
                                CustomerName = "Grab",
                                Country = "SG",
                                PowerGeneration = 300,
                                Longitude = 0,
                                Latitude = 0,
                                StartDate = DateTime.Parse("2020-12-12")
                            },
                             new Project
                             {
                                 Name = "SG Test Project 5",
                                 Code = "SG5",
                                 CustomerName = "Grab",
                                 Country = "SG",
                                 PowerGeneration = 300,
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
