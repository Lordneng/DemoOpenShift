using DemoOpenShift.Services.Contracts;
using DemoOpenShift.Services.Interfaces;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOpenShift.UnitTests
{
    [TestFixture]
    [Category("CalculatorService")]
    public class CalculatorServiceTest
    {
        private ICalculatorService _calculatorService;

        [SetUp]
        public void SetUp()
        {
            _calculatorService = new CalculatorService();
        }

        [TearDown]
        public void TearDown()
        {
            _calculatorService = null;
        }

        [Test]
        [TestCase(1,1)]
        public void Plus_NumberAPlusNumberB_ReturnTrue(int A, int B)
        {
            int result = 0;

            result = _calculatorService.Plus(A, B);

            Assert.AreEqual(result, 2);
        }
    }
}
