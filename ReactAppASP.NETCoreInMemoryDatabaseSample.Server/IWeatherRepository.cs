namespace ReactAppASP.NETCoreInMemoryDatabaseSample.Server
{
    public interface IWeatherRepository
    {
        public List<WeatherForecast> GetWeather();

    }
}
