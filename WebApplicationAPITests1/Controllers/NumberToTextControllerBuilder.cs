using Microsoft.Extensions.Logging;
using NumberToTextConverter;
using System;
using System.Collections.Generic;
using System.Text;
using WebApplicationAPI.Controllers;
using Moq;

namespace WebApplicationAPITests.Controllers
{
    public class NumberToTextControllerBuilder
    {
        private NumberToTextController _NumberToTextController;
        private Mock<ILogger<NumberToTextController>> _mockLogger;
        private Mock<IMyConverter> _mockMyConverter;

        public NumberToTextControllerBuilder()
        {
        }
                public NumberToTextControllerBuilder Default()
        {
            _mockMyConverter = new Mock<IMyConverter>();
            _mockLogger = new Mock<ILogger<NumberToTextController>>();
            return this;
        }

        public NumberToTextControllerBuilder WithMyConverter(Mock<IMyConverter> myConverter)
        {
            _mockMyConverter = myConverter;
            return this;
        }

        public NumberToTextControllerBuilder WithLogger(Mock<ILogger<NumberToTextController>> logger)
        {
            _mockLogger = logger;
            return this;
        }

        public NumberToTextController Build()
        {
            _NumberToTextController = new NumberToTextController(
            _mockLogger.Object,
            _mockMyConverter.Object);
            return _NumberToTextController;
        }
    }
}
