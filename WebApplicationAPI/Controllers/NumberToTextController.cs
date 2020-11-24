using Microsoft.AspNetCore.Mvc;
using NumberToTextConverter;
using System;

namespace WebApplicationAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NumberToTextController : ControllerBase
    {
        private readonly IMyConverter _myConverter;

        public NumberToTextController(
            IMyConverter myConverter)
        {
            _myConverter = myConverter;
        }

        [HttpGet("{amount}")]
        public NumberToText Get(double amount)
        {
            var dollers = Math.Floor(amount);
            var cents = (int)(((decimal)amount % 1) * 100);
            string text = GetDollers(dollers) + " and " + GetCents(cents);

            return new NumberToText()
            {
                NumberInText = text,
                Number = amount
            };

        }
        string GetDollers(double id)
        {
            var dollerText = " Dollars";
            if (id==1)
                dollerText = " Dollar";

            return _myConverter.ConvertToWords(id) + dollerText;
        }
        string GetCents(double id)
        {
            var centText = " Cents";
            if (id == 1)
                centText = " Cent";

            return _myConverter.ConvertToWords(id) + centText;
        }
    }
}
