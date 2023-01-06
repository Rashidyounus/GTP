using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Azure.Messaging.ServiceBus;
using System.Text.Json;

namespace AzureTopics.Controllers
{
    [ApiController]
   [Route("[controller]")]
    //[Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name ="GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpPost]
        
        public async Task<IActionResult> Post(WeatherForecast data)
        {
            var message = new WeatherForecastAdded()
            {
                Id = Guid.NewGuid(),
                CreatedDateTime = DateTime.UtcNow,
                ForDate = data.Date

            };

            var conn = "Endpoint=sb://azurebustopics.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=82nblMPoaXBo/sDTArQ0bkZ9CgYPKlJ2EGGSXTfo/iA=";
            var client = new ServiceBusClient(conn);
            var sender = client.CreateSender("weather-forcast-added");
            var body = JsonSerializer.Serialize(message);
            var sbmessage = new ServiceBusMessage(body);
           
            await sender.SendMessageAsync(sbmessage);



            return Ok();
        }
    }
}
