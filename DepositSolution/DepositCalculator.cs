using System;
using System.Collections.Generic;
using System.Text;

namespace DepositApp
{
    public class DepositCalculator
    {
        public decimal Calculate(decimal principal, decimal rate, int years)
        {
            if (principal <= 0)
                throw new ArgumentException("Сумма вклада должна быть больше 0");

            if (rate < 0)
                throw new ArgumentException("Процентная ставка не может быть отрицательной");

            if (years <= 0)
                throw new ArgumentException("Срок должен быть больше 0");

            return principal * (1 + rate * years);
        }
    }
}
