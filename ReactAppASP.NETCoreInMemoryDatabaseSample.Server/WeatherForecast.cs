using System.ComponentModel.DataAnnotations;

namespace ReactAppASP.NETCoreInMemoryDatabaseSample.Server
{
    public class WeatherForecast
    {
        [Key]
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
}
