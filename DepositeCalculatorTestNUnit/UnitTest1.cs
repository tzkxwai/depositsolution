using NUnit.Framework;
using DepositApp;

namespace DepositeCalculatorTestNUnit
{
    public class Tests
    {
        private DepositCalculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new DepositCalculator();
        }

        [Test]
        public void Calculate_ValidData_ReturnsCorrectResult()
        {
            var result = _calculator.Calculate(1000, 0.1m, 2);
            Assert.AreEqual(1200, result);
        }

        [TestCase(1000, 0.05, 1, 1050)]
        [TestCase(2000, 0.1, 1, 2200)]
        public void Calculate_MultipleValidInputs_ReturnsCorrect(
            decimal sum, decimal rate, int years, decimal expected)
        {
            var result = _calculator.Calculate(sum, rate, years);
            NUnit.Framework.Assert.AreEqual(expected, result);
        }

        [Test]
        public void Calculate_PrincipalZero_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() =>
                _calculator.Calculate(0, 0.1m, 2));
        }

        [Test]
        public void Calculate_NegativeRate_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() =>
                _calculator.Calculate(1000, -0.1m, 2));
        }

        [Test]
        public void Calculate_YearsZero_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() =>
                _calculator.Calculate(1000, 0.1m, 0));
        }
    }
}
