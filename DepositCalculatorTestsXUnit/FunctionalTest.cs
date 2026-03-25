using DepositApp;
using System;
using System.Collections.Generic;
using System.Text;

namespace DepositCalculatorTestsXUnit
{
    internal class FunctionalTest
    {
        public void Functional_DepositScenario()
        {
            var calculator = new DepositCalculator();

            decimal sum = 5000;
            decimal rate = 0.1m;
            int years = 3;

            var result = calculator.Calculate(sum, rate, years);

            Assert.Equal(6500, result);
        }
    }
}
