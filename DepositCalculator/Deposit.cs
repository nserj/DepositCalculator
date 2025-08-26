using System;

using DepositCalculator.Enums;

namespace DepositCalculator
{
    /// <summary>
    /// Class to support deposit data
    /// </summary>
    public class Deposit : IDeposit
    {
        /// <inheritdoc/>
        public double Amount { get; set; } = 1;

        /// <inheritdoc/>
        public double Rate { get; set; } = 1;

        /// <inheritdoc/>
        public int Term { get; set; } = 1;

        /// <inheritdoc/>
        public CurrenciesEnum Currency { get; set; }
        /// <inheritdoc/>
        public InterestPaymentMethodEnum InterestPaymentMethod { get; set; }

        /// <inheritdoc/>
        public double CalculateIncome()
        {
            double incomeAmount = 0;
            int numberOfDays = DateTime.IsLeapYear(DateTime.Now.Year) ? 366 : 365;
            var startDate = DateTime.Now;
            int termDays = (int)(startDate.AddMonths(Term) - startDate).TotalDays;

            switch (InterestPaymentMethod)
            {
                case InterestPaymentMethodEnum.Monthly:
                    incomeAmount = Amount * Rate * termDays / numberOfDays / 100;
                    break;
                case InterestPaymentMethodEnum.CapitalizationMonthly:
                    incomeAmount = (Amount * Math.Pow(1 + (Rate / 1200), Term)) - Amount;
                    break;
                default:
                    incomeAmount = (Amount * Math.Pow(1 + (Rate / 100 / numberOfDays), termDays)) - Amount;
                    break;
            }

            return incomeAmount;
        }

        /// <inheritdoc/>
        public string CalculateIncomeAsString()
        {
            return $"{CalculateIncome():F2}  {Currency}";
        }
    }
}
