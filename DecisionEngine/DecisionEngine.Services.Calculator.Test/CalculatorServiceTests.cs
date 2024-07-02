using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DecisionEngine.Services.Calculator.Tests
{
    [TestClass]
    public class CalculatorServiceTests
    {
        private CalculatorService _calculatorService;

        [TestInitialize]
        public void Setup()
        {
            _calculatorService = new CalculatorService();
        }

        [TestMethod]
        public void ProcessAdd()
        {
            const decimal originalSum = 0.5M;
            const decimal value = 1.0M;

            var expectedSum = originalSum
                              + value;

            var resultSum = _calculatorService.ProcessAdd(originalSum, value);

            Assert.AreEqual(expectedSum, resultSum);
        }

        [TestMethod]
        public void ProcessMultiply()
        {
            const decimal factorLeft = 3.0M;
            const decimal factorRight = 2.0M;

            var expectedProduct = factorLeft
                                  * factorRight;

            var resultProduct = _calculatorService.ProcessMultiply(factorLeft, factorRight);

            Assert.AreEqual(expectedProduct, resultProduct);
        }

        [TestMethod]
        public void ProcessPower()
        {
            const decimal factorBase = 3.0M;
            const decimal factorExponent = 2.0M;

            var expectedPower = (decimal)Math.Pow(
                (double)factorBase,
                (double)factorExponent);

            var resultPower = _calculatorService.ProcessPower(factorBase, factorExponent);

            Assert.AreEqual(expectedPower, resultPower);
        }

        [TestMethod]
        public void ProcessPythagorean()
        {
            // a^2 + b^2 = c^2
            // 9 + 4 = 13
            const decimal a = 3.0M;
            const decimal b = 2.0M;

            var expectedAPower2 = (decimal)Math.Pow(
                (double)a,
                (double)2);

            var expectedBPower2 = (decimal)Math.Pow(
                (double)b,
                (double)2);

            var expectedSum = expectedAPower2
                              + expectedBPower2;

            var resultAPower2 = _calculatorService.ProcessPower(a, 2);
            var resultBPower2 = _calculatorService.ProcessPower(b, 2);

            var resultSum = resultAPower2 
                            + resultBPower2;

            Assert.AreEqual(expectedSum, resultSum);

            var expectedC = (decimal)Math.Pow(
                (double)expectedSum,
                (double)0.5);

            var resultC = _calculatorService.ProcessPower(resultSum, 0.5M);

            Assert.AreEqual(expectedC, resultC);
        }
    }
}
