using Moq;
using NumberToTextConverter;
using System;
using Xunit;
using XUnitTestProject;

namespace XUnitTestProject
{
    public class TestConvertToWords
    {
        [Fact]
        public void CheckNull_ReturnsEmptyString()
        {
            var _MyConverter = new MyConverter();
            Assert.Equal("empty string", _MyConverter.ConvertToWords(null));
        }

        [Fact]
        public void CheckNotANumber()
        {
            var _MyConverter = new MyConverter();
            Assert.Equal("empty string", _MyConverter.ConvertToWords(double.NaN));
        }

        [Fact]
        public void CheckMinus1()
        {
            var _MyConverter = new MyConverter();
            Assert.Equal("one", _MyConverter.ConvertToWords(-1));
        }

        [Fact]
        public void Check10000()
        {
            var _MyConverter = new MyConverter();
            Assert.Equal("Length more than 4 is not supported", _MyConverter.ConvertToWords(10000));
        }

        [Fact]
        public void Check0to9()
        {
            var _MyConverter = new MyConverter();
            Assert.Equal("zero", _MyConverter.ConvertToWords(0));
            Assert.Equal("one", _MyConverter.ConvertToWords(1));
            Assert.Equal("two", _MyConverter.ConvertToWords(2));
            Assert.Equal("three", _MyConverter.ConvertToWords(3));
            Assert.Equal("four", _MyConverter.ConvertToWords(4));
            Assert.Equal("five", _MyConverter.ConvertToWords(5));
            Assert.Equal("six", _MyConverter.ConvertToWords(6));
            Assert.Equal("seven", _MyConverter.ConvertToWords(7));
            Assert.Equal("eight", _MyConverter.ConvertToWords(8));
            Assert.Equal("nine", _MyConverter.ConvertToWords(9));
        }

        [Fact]
        public void Check10to19()
        {
            var _MyConverter = new MyConverter();
            Assert.Equal("ten", _MyConverter.ConvertToWords(10));
            Assert.Equal("eleven", _MyConverter.ConvertToWords(11));
            Assert.Equal("twelve", _MyConverter.ConvertToWords(12));
            Assert.Equal("thirteen", _MyConverter.ConvertToWords(13));
            Assert.Equal("fourteen", _MyConverter.ConvertToWords(14));
            Assert.Equal("fifteen", _MyConverter.ConvertToWords(15));
            Assert.Equal("sixteen", _MyConverter.ConvertToWords(16));
            Assert.Equal("seventeen", _MyConverter.ConvertToWords(17));
            Assert.Equal("eighteen", _MyConverter.ConvertToWords(18));
            Assert.Equal("nineteen", _MyConverter.ConvertToWords(19));
        }

        [Fact]
        public void Check20()
        {
            var _MyConverter = new MyConverter();
            Assert.Equal("twenty", _MyConverter.ConvertToWords(20));
        }

        [Fact]
        public void Check21to29()
        {
            var _MyConverter = new MyConverter();
            Assert.Equal("twenty one", _MyConverter.ConvertToWords(21));
            Assert.Equal("twenty two", _MyConverter.ConvertToWords(22));
            Assert.Equal("twenty three", _MyConverter.ConvertToWords(23));
            Assert.Equal("twenty four", _MyConverter.ConvertToWords(24));
            Assert.Equal("twenty five", _MyConverter.ConvertToWords(25));
            Assert.Equal("twenty six", _MyConverter.ConvertToWords(26));
            Assert.Equal("twenty seven", _MyConverter.ConvertToWords(27));
            Assert.Equal("twenty eight", _MyConverter.ConvertToWords(28));
            Assert.Equal("twenty nine", _MyConverter.ConvertToWords(29));
        }

        [Fact]
        public void Check30to31()
        {
            var _MyConverter = new MyConverter();
            Assert.Equal("thirty", _MyConverter.ConvertToWords(30));
            Assert.Equal("thirty one", _MyConverter.ConvertToWords(31));
        }

        [Fact]
        public void Check40to41()
        {
            var _MyConverter = new MyConverter();
            Assert.Equal("forty", _MyConverter.ConvertToWords(40));
            Assert.Equal("forty one", _MyConverter.ConvertToWords(41));
        }
        [Fact]
        public void Check50to51()
        {
            var _MyConverter = new MyConverter();
            Assert.Equal("fifty", _MyConverter.ConvertToWords(50));
            Assert.Equal("fifty one", _MyConverter.ConvertToWords(51));
        }
        [Fact]
        public void Check60to61()
        {
            var _MyConverter = new MyConverter();
            Assert.Equal("sixty", _MyConverter.ConvertToWords(60));
            Assert.Equal("sixty one", _MyConverter.ConvertToWords(61));
        }
        [Fact]
        public void Check70to71()
        {
            var _MyConverter = new MyConverter();
            Assert.Equal("seventy", _MyConverter.ConvertToWords(70));
            Assert.Equal("seventy one", _MyConverter.ConvertToWords(71));
        }
        [Fact]
        public void Check80to81()
        {
            var _MyConverter = new MyConverter();
            Assert.Equal("eighty", _MyConverter.ConvertToWords(80));
            Assert.Equal("eighty one", _MyConverter.ConvertToWords(81));
        }
        [Fact]
        public void Check90to91()
        {
            var _MyConverter = new MyConverter();
            Assert.Equal("ninety", _MyConverter.ConvertToWords(90));
            Assert.Equal("ninety one", _MyConverter.ConvertToWords(91));
        }
        [Fact]
        public void Check99()
        {
            var _MyConverter = new MyConverter();
            Assert.Equal("ninety nine", _MyConverter.ConvertToWords(99));
        }
        [Fact]
        public void Check100to101adn110and120adn121()
        {
            var _MyConverter = new MyConverter();
            Assert.Equal("one hundred", _MyConverter.ConvertToWords(100));
            Assert.Equal("one hundred one", _MyConverter.ConvertToWords(101));
            Assert.Equal("one hundred ten", _MyConverter.ConvertToWords(110));
            Assert.Equal("one hundred twenty", _MyConverter.ConvertToWords(120));
            Assert.Equal("one hundred twenty one", _MyConverter.ConvertToWords(121));
        }
        [Fact]
        public void Check200to201and210()
        {
            var _MyConverter = new MyConverter();
            Assert.Equal("two hundred", _MyConverter.ConvertToWords(200));
            Assert.Equal("two hundred one", _MyConverter.ConvertToWords(201));
            Assert.Equal("two hundred ten", _MyConverter.ConvertToWords(210));
        }
        [Fact]
        public void Check300to301()
        {
            var _MyConverter = new MyConverter();
            Assert.Equal("three hundred", _MyConverter.ConvertToWords(300));
            Assert.Equal("three hundred one", _MyConverter.ConvertToWords(301));
        }
        [Fact]
        public void Check1000and1001and1010and1020and1021()
        {
            var _MyConverter = new MyConverter();
            Assert.Equal("one thousand", _MyConverter.ConvertToWords(1000));
            Assert.Equal("one thousand one", _MyConverter.ConvertToWords(1001));
            Assert.Equal("one thousand ten", _MyConverter.ConvertToWords(1010));
            Assert.Equal("one thousand twenty", _MyConverter.ConvertToWords(1020));
            Assert.Equal("one thousand twenty one", _MyConverter.ConvertToWords(1021));
        }

        //million 
        //billion 
    }
}
