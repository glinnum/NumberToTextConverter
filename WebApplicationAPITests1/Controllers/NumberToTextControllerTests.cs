using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplicationAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Text;
using WebApplicationAPITests.Controllers;
using Moq;
using Castle.Core.Logging;
using Microsoft.Extensions.Logging;

namespace WebApplicationAPI.Controllers.Tests
{
    [TestClass()]
    public class NumberToTextControllerTests
    {

        [TestMethod()]
        public void Get1_01ReturnsOneDollerAndOneCent()
        {
            var control = new NumberToTextControllerBuilder().Default().Build();
            var result = control.Get(1.01d);
            Assert.AreEqual("one Dollar and one Cent", result.NumberInText);
            Assert.AreEqual(1.01d, result.Number);
        }

        [TestMethod()]
        public void Get1_01ReturnsOneDollerAndOneCentAndWriteToLock()
        {
            var control = new NumberToTextControllerBuilder().Default().Build();
            var result = control.Get(1.01d);
            Assert.AreEqual("one Dollar and one Cent", result.NumberInText);
            Assert.AreEqual(1.01d, result.Number);
        }

        [TestMethod()]
        public void Get1_029ReturnsOneDollerAndTwoCents()
        {
            var control = new NumberToTextControllerBuilder().Default().Build();
            var result = control.Get(1.029d);
            Assert.AreEqual("one Dollar and two Cents", result.NumberInText);
            Assert.AreEqual(1.029d, result.Number);
        }

        [TestMethod()]
        public void Get1ReturnsOneDoller()
        {
            var control = new NumberToTextControllerBuilder().Default().Build();
            var result = control.Get(1);
            Assert.AreEqual("one Dollar and zero Cents", result.NumberInText);
            Assert.AreEqual(1, result.Number);
        }

        [TestMethod()]
        public void Get2ReturnsTwoDollers()
        {
            var control = new NumberToTextControllerBuilder().Default().Build();
            var result = control.Get(2);
            Assert.AreEqual("two Dollars and zero Cents", result.NumberInText);
            Assert.AreEqual(2, result.Number);
        }

        [TestMethod()]
        public void Get10ReturnsTen()
        {
            var control = new NumberToTextControllerBuilder().Default().Build();
            var result = control.Get(10);
            Assert.AreEqual("ten Dollars and zero Cents", result.NumberInText);
            Assert.AreEqual(10, result.Number);
        }
    }
}