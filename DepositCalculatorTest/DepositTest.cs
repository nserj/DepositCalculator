using System;

using DepositCalculator;
using DepositCalculator.Enums;

namespace DepositCalculatorTest
{
    public class DepositTest
    {
        [Theory]
        [InlineData(InterestPaymentMethodEnum.CapitalizationMonthly, 12533)]
        [InlineData(InterestPaymentMethodEnum.CapitalizationDaily, 12522)]
        [InlineData(InterestPaymentMethodEnum.Monthly, 12304)]
        public void Should_Calculate_Deposit_Correctly(InterestPaymentMethodEnum paymentType, double depositValueToCheck)
        {
            var deposit = CreateDeposit(paymentType);
            Assert.Equal(depositValueToCheck, Math.Round(deposit.CalculateIncome(), 0));
        }

        private IDeposit CreateDeposit(InterestPaymentMethodEnum method)
        {
            return new Deposit()
            {
                Amount = 350000,
                Currency = CurrenciesEnum.USD,
                InterestPaymentMethod = method,
                Rate = 4.7,
                Term = 9
            };
        }
    }
}