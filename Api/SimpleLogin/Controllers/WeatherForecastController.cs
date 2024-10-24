using Microsoft.AspNetCore.Mvc;
using SimpleLogin.Repository;

namespace SimpleLogin.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };


        private readonly IConfiguration _config;

        private readonly ILogger<WeatherForecastController> _logger;

        private readonly IUnitOfWork _unitOfWork;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IConfiguration config, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _config = config;
            _unitOfWork = unitOfWork;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            var constring = _config["DbConnectionString"];




            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("GetSamples")]
        public IActionResult GetSamples() 
        { 
            var result = _unitOfWork.Samples.GetSamples();

            return Ok(result);
        }

    }
}
