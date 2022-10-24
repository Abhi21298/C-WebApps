using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication20Exercise2.Models;

namespace WebApplication20Exercise2.Controllers
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
        private IAccountTransient _transientAccount;
        private IAccountScoped _scopedAccount;
        private IAccountSingleton _singletonAccount;
        public WeatherForecastController(ILogger<WeatherForecastController> logger,IAccountTransient transient)
        {
            _logger = logger;
            _transientAccount = transient;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            _transientAccount.Getdetails("200012923", "Abhijeet", 2000.0);
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
