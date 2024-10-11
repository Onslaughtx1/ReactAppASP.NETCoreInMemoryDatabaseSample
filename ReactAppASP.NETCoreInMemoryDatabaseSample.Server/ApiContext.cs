using Microsoft.EntityFrameworkCore;

namespace ReactAppASP.NETCoreInMemoryDatabaseSample.Server
{
    public class ApiContext : DbContext
    {
        protected override void OnConfiguring
       (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "weatherforecasts");
        }
        public DbSet<WeatherForecast> WeatherForecasts { get; set; }
    }
}
