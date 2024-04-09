using Microsoft.AspNetCore.Mvc;

namespace Kurs_Udemy_2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWeatherForecastService _service;


        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherForecastService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpPost]
        [Route("generate")]
        public ActionResult <IEnumerable<WeatherForecast>> Generate([FromQuery]int resultCount, [FromBody] TemperatureRequest minmax)
        {
            if (resultCount < 0 || minmax.maxTemperature < minmax.minTemperature)
            {
                return BadRequest();
            }
            var result = _service.Get(resultCount, minmax.minTemperature, minmax.maxTemperature);
            return Ok(result);
        }
    }
}