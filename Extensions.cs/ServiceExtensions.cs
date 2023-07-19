
using Microsoft.EntityFrameworkCore;

namespace mvc_energy_plants.Extensions.cs
{
    public static class ServiceExtensions
    {
        public static void ConfigureDbContext(this IServiceCollection services, WebApplicationBuilder builder)
        {
            services.AddDbContext<energy_plantsContext>();

            //services.AddDbContext<energy_plantsContext>(options =>
            //   options.UseSqlServer(builder.Configuration.GetConnectionString("energy_plantsContext")
            //   ?? throw new InvalidOperationException("Connection string 'energy_plantsContext' not found.")));


        }
    }
}
