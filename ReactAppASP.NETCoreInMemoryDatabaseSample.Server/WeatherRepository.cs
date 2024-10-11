namespace ReactAppASP.NETCoreInMemoryDatabaseSample.Server
{
    public class WeatherRepository : IWeatherRepository
    {
        private static readonly string[] Summaries = new[]
{
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public WeatherRepository() 
        {
            var weatherList = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            }).ToList();

            using (var context = new ApiContext())
            {
                if(context.WeatherForecasts.Count()==0)
                {
                    context.WeatherForecasts.AddRange(weatherList);
                    context.SaveChanges();
                }

            }
        }
        public List<WeatherForecast> GetWeather()
        {
            using (var context = new ApiContext())
            {
                var list = context.WeatherForecasts
                    .ToList();

                return list;
            }
        }
    }
}
