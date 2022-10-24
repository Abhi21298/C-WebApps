using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication18.Models;

namespace WebApplication18.Controllers
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
        //private IOperationTransient _transientOperation;
        //private IOperationScoped _ScopedOperation;
        private IOperationSingleton _SingletonOperation;
        public WeatherForecastController(ILogger<WeatherForecastController> logger, IOperationSingleton single)
        {
            _logger = logger;
            //_transientOperation = transient;
            //_ScopedOperation = scoped;
            _SingletonOperation = single;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            Console.WriteLine(_SingletonOperation.OperationID);
            
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
