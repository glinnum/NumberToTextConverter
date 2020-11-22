using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplicationAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Text;
using WebApplicationAPITests.Controllers;

namespace WebApplicationAPI.Controllers.Tests
{
    [TestClass()]
    public class NumberToTextControllerTests
    {
        [TestMethod()]
        public void Get1ReturnsOne()
        {
            NumberToTextController control = new NumberToTextControllerBuilder().Default().Build();
            var result = control.Get(1);
            Assert.AreEqual("one Dollars", result.NumberInText);
            Assert.AreEqual(1, result.Number);
        }

        [TestMethod()]
        public void Get10ReturnsTen()
        {
            NumberToTextController control = new NumberToTextControllerBuilder().Default().Build();
            var result = control.Get(10);
            Assert.AreEqual("ten Dollars", result.NumberInText);
            Assert.AreEqual(10, result.Number);
        }
    }
}