namespace Kurs_Udemy_2
{
    public interface IWeatherForecastService
    {
        IEnumerable<WeatherForecast> Get(int resultCount, int minTemperature, int maxTemperaure);
    }
}