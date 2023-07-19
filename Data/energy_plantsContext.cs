using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using mvc_energy_plants.Models;

public class energy_plantsContext : DbContext
{
    public energy_plantsContext(DbContextOptions<energy_plantsContext> options)
        : base(options) { }

    public DbSet<mvc_energy_plants.Models.Project> Project { get; set; } = default!;

    public DbSet<mvc_energy_plants.Models.ProjectStopLog> ProjectStopLog { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //optionsBuilder.UseSqlite(@"Data Source=Project.db");
        optionsBuilder.UseInMemoryDatabase("Project");
    }
}
