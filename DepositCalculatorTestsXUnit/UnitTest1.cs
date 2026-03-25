using DepositApp;
using Xunit;

namespace DepositCalculatorTestsXUnit
{
    public class UnitTest1
    {
        
        private readonly DepositCalculator _calculator = new();

        [Fact]
        public void Calculate_ValidData_ReturnsCorrectResult()
        {
            var result = _calculator.Calculate(1000, 0.1m, 2);
            Assert.Equal(1200, result);
        }

        [Theory]
        [InlineData(1000, 0.05, 1, 1050)]
        [InlineData(2000, 0.1, 1, 2200)]
        public void Calculate_MultipleValidInputs_ReturnsCorrect(decimal sum, decimal rate, int years, decimal expected)
        {
            var result = _calculator.Calculate(sum, rate, years);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Calculate_PrincipalZero_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() =>
                _calculator.Calculate(0, 0.1m, 2));
        }

        [Fact]
        public void Calculate_NegativeRate_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() =>
                _calculator.Calculate(1000, -0.1m, 2));
        }

        [Fact]
        public void Calculate_YearsZero_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() =>
                _calculator.Calculate(1000, 0.1m, 0));
        }
    }
}
