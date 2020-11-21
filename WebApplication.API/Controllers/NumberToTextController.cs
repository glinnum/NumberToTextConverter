using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApplication.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NumberToTextController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing2", "Bracing2", "Chilly2", "Cool2", "Mild2", "Warm2", "Balmy2", "Hot2", "Sweltering2", "Scorching2"
        };

        private readonly ILogger<NumberToTextController> _logger;

        public NumberToTextController(ILogger<NumberToTextController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("api/NumberToText")]
        public IEnumerable<NumberToText> Get(double id)
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new NumberToText
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)],
                Number = id
            })
            .ToArray();
        }
    }
}
