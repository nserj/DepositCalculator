using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using DepositCalculator.Enums;
using DepositCalculator.Extensions;

namespace DepositCalculator
{
    public partial class CalculatorForm : Form
    {
        private IDeposit _depositObject;
        private KeyValuePair<CurrenciesEnum, string> _currentCurrency = new();
        private KeyValuePair<InterestPaymentMethodEnum, string> _currentInterestPaymentMethod = new();

        public KeyValuePair<CurrenciesEnum, string> CurrentCurrency
        {
            get => _currentCurrency;
            set
            {
                _currentCurrency = value;
                _depositObject.Currency = value.Key;
            }
        }

        public KeyValuePair<InterestPaymentMethodEnum, string> CurrentInterestPaymentMethod
        {
            get => _currentInterestPaymentMethod;
            set
            {
                _currentInterestPaymentMethod = value;
                _depositObject.InterestPaymentMethod = value.Key;
            }
        }

        public CalculatorForm(IDeposit depositObject)
        {
            _depositObject = depositObject;
            InitializeComponent();
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {
            AmountInput.DataBindings.Add(nameof(AmountInput.Value), _depositObject, nameof(Deposit.Amount));
            RateInput.DataBindings.Add(nameof(RateInput.Value), _depositObject, nameof(Deposit.Rate));
            TermInput.DataBindings.Add(nameof(TermInput.Value), _depositObject, nameof(Deposit.Term));
            BindCurrencies();
            BindPaymentMethod();
        }

        private List<KeyValuePair<InterestPaymentMethodEnum, string>> GetPaymentMethods()
        {
            var method = (List<KeyValuePair<InterestPaymentMethodEnum, string>>)
                 [ new KeyValuePair<InterestPaymentMethodEnum,string>(  InterestPaymentMethodEnum.CapitalizationMonthly, "Capitalization Monthly"),
                new KeyValuePair<InterestPaymentMethodEnum,string>(  InterestPaymentMethodEnum.CapitalizationDaily, "Capitalization Daily"),
                new KeyValuePair<InterestPaymentMethodEnum,string>(InterestPaymentMethodEnum.Monthly, nameof(InterestPaymentMethodEnum.Monthly))];

            CurrentInterestPaymentMethod = method[0];
            return method;
        }

        private List<KeyValuePair<CurrenciesEnum, string>> GetCurrencies()
        {
            var currenciesList = new List<KeyValuePair<CurrenciesEnum, string>>();
            foreach (CurrenciesEnum value in Enum.GetValues(typeof(CurrenciesEnum)))
            {
                currenciesList.Add(new KeyValuePair<CurrenciesEnum, string>(value, value.GetDescription()));
            }

            CurrentCurrency = currenciesList.First(e => e.Key == CurrenciesEnum.USD);
            return currenciesList.OrderBy(e => e.Value).ToList();
        }

        private void BindCurrencies()
        {
            cbCurrency.DataSource = GetCurrencies();
            cbCurrency.DisplayMember = "Value";
            cbCurrency.ValueMember = "Key";
            cbCurrency.DataBindings.Add(nameof(cbCurrency.SelectedItem), this, nameof(CurrentCurrency));
        }

        private void BindPaymentMethod()
        {
            cbInterestType.DataSource = GetPaymentMethods();
            cbInterestType.DisplayMember = "Value";
            cbInterestType.ValueMember = "Key";
            cbInterestType.DataBindings.Add(nameof(cbInterestType.SelectedItem), this, nameof(CurrentInterestPaymentMethod));
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            lbIncome.Text = _depositObject.CalculateIncomeAsString();
        }
    }
}
