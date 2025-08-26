using DepositCalculator.Enums;

namespace DepositCalculator
{
    /// <summary>
    /// Interface for Deposit class
    /// </summary>
    public interface IDeposit
    {
        /// <summary>
        /// Deposit amount
        /// </summary>
        double Amount { get; set; }

        /// <summary>
        /// Currency of the deposit
        /// </summary>
        CurrenciesEnum Currency { get; set; }

        /// <summary>
        /// Interest payment method
        /// </summary>
        InterestPaymentMethodEnum InterestPaymentMethod { get; set; }

        /// <summary>
        /// Deposit rate
        /// </summary>
        double Rate { get; set; }

        /// <summary>
        /// Deposit term
        /// </summary>
        int Term { get; set; }

        /// <summary>
        /// Claculate deposit income as string
        /// </summary>
        string CalculateIncomeAsString();

        /// <summary>
        /// Claculate deposit income
        /// </summary>
        double CalculateIncome();
    }
}