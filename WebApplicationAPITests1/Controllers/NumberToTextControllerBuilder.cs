using NumberToTextConverter;
using WebApplicationAPI.Controllers;

namespace WebApplicationAPITests.Controllers
{
    public class NumberToTextControllerBuilder
    {
        private NumberToTextController _NumberToTextController;
        private IMyConverter _MyConverter;

        public NumberToTextControllerBuilder()
        {
        }
                public NumberToTextControllerBuilder Default()
        {
            _MyConverter = new MyConverter();
            return this;
        }

        public NumberToTextController Build()
        {
            _NumberToTextController = new NumberToTextController(
            _MyConverter);
            return _NumberToTextController;
        }
    }
}
