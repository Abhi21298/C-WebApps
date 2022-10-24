using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication18Exercise.Models;
namespace WebApplication18Exercise.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IEmployeeTransient _employeeTransient;
        private readonly IEmployeeScoped _employeeScoped;
        private readonly IEmployeeSingleton _employeeSingleton;
        public WeatherForecastController(ILogger<WeatherForecastController> logger,IEmployeeSingleton objectA)
        {
            _logger = logger;
            _employeeSingleton = objectA;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            _employeeSingleton.GetName("Abhijeet");
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
