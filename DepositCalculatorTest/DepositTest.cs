using System;

using DepositCalculator;
using DepositCalculator.Enums;

namespace DepositCalculatorTest
{
    public class DepositTest
    {
        [Fact]
        public void Should_Calculate_Deposit_CapitalizationMonthly_Correctly()
        {
            var deposit = CreateDeposit(InterestPaymentMethodEnum.CapitalizationMonthly);
            Assert.Equal(12533, Math.Round(deposit.CalculateIncome(), 0));
        }

        [Fact]
        public void Should_Calculate_Deposit_CapitalizationDaily_Correctly()
        {
            var deposit = CreateDeposit(InterestPaymentMethodEnum.CapitalizationDaily);
            Assert.Equal(12522, Math.Round(deposit.CalculateIncome(), 0));
        }

        [Fact]
        public void Should_Calculate_Deposit_Monthly_Correctly()
        {
            var deposit = CreateDeposit(InterestPaymentMethodEnum.Monthly);
            Assert.Equal(12304, Math.Round(deposit.CalculateIncome(), 0));
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