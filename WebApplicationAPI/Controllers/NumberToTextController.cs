using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NumberToTextConverter;

namespace WebApplicationAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NumberToTextController : ControllerBase
    {
        private readonly IMyConverter _myConverter;
        private readonly ILogger<NumberToTextController> _logger;

        public NumberToTextController(
            ILogger<NumberToTextController> logger, 
            IMyConverter myConverter)
        {
            _logger = logger;
            _myConverter = myConverter;
        }

        [HttpGet("{id}")]
        public NumberToText Get(double id)
        {
            _logger.LogInformation(message: $"Number = {id}");
            var text = _myConverter.ConvertToWords(id)+ " Dollars";
            return new NumberToText()
            {
                NumberInText = text,
                Number = id
            };
        }
    }
}
