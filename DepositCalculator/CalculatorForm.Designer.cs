namespace DepositCalculator
{
    partial class CalculatorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new System.Windows.Forms.GroupBox();
            RateInput = new System.Windows.Forms.NumericUpDown();
            lbRate = new System.Windows.Forms.Label();
            cbCurrency = new System.Windows.Forms.ComboBox();
            lbCurrencies = new System.Windows.Forms.Label();
            cbInterestType = new System.Windows.Forms.ComboBox();
            lbInterestType = new System.Windows.Forms.Label();
            TermInput = new System.Windows.Forms.NumericUpDown();
            lbTerm = new System.Windows.Forms.Label();
            AmountInput = new System.Windows.Forms.NumericUpDown();
            lbDepositAmount = new System.Windows.Forms.Label();
            btnCalculate = new System.Windows.Forms.Button();
            lbIncome = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RateInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TermInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AmountInput).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            groupBox1.Controls.Add(RateInput);
            groupBox1.Controls.Add(lbRate);
            groupBox1.Controls.Add(cbCurrency);
            groupBox1.Controls.Add(lbCurrencies);
            groupBox1.Controls.Add(cbInterestType);
            groupBox1.Controls.Add(lbInterestType);
            groupBox1.Controls.Add(TermInput);
            groupBox1.Controls.Add(lbTerm);
            groupBox1.Controls.Add(AmountInput);
            groupBox1.Controls.Add(lbDepositAmount);
            groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            groupBox1.Location = new System.Drawing.Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(447, 201);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = " Calculation Parameters ";
            // 
            // RateInput
            // 
            RateInput.DecimalPlaces = 2;
            RateInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            RateInput.Location = new System.Drawing.Point(160, 59);
            RateInput.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            RateInput.Minimum = new decimal(new int[] { 1, 0, 0, 65536 });
            RateInput.Name = "RateInput";
            RateInput.Size = new System.Drawing.Size(64, 23);
            RateInput.TabIndex = 2;
            RateInput.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lbRate
            // 
            lbRate.AutoSize = true;
            lbRate.Font = new System.Drawing.Font("Segoe UI", 9F);
            lbRate.Location = new System.Drawing.Point(11, 61);
            lbRate.Name = "lbRate";
            lbRate.Size = new System.Drawing.Size(54, 15);
            lbRate.TabIndex = 8;
            lbRate.Text = "Rate (%):";
            // 
            // cbCurrency
            // 
            cbCurrency.Font = new System.Drawing.Font("Segoe UI", 9F);
            cbCurrency.FormattingEnabled = true;
            cbCurrency.Location = new System.Drawing.Point(160, 156);
            cbCurrency.Name = "cbCurrency";
            cbCurrency.Size = new System.Drawing.Size(253, 23);
            cbCurrency.TabIndex = 5;
            // 
            // lbCurrencies
            // 
            lbCurrencies.AutoSize = true;
            lbCurrencies.Font = new System.Drawing.Font("Segoe UI", 9F);
            lbCurrencies.Location = new System.Drawing.Point(12, 159);
            lbCurrencies.Name = "lbCurrencies";
            lbCurrencies.Size = new System.Drawing.Size(58, 15);
            lbCurrencies.TabIndex = 6;
            lbCurrencies.Text = "Currency:";
            // 
            // cbInterestType
            // 
            cbInterestType.Font = new System.Drawing.Font("Segoe UI", 9F);
            cbInterestType.FormattingEnabled = true;
            cbInterestType.Location = new System.Drawing.Point(160, 123);
            cbInterestType.Name = "cbInterestType";
            cbInterestType.Size = new System.Drawing.Size(253, 23);
            cbInterestType.TabIndex = 4;
            // 
            // lbInterestType
            // 
            lbInterestType.AutoSize = true;
            lbInterestType.Font = new System.Drawing.Font("Segoe UI", 9F);
            lbInterestType.Location = new System.Drawing.Point(12, 126);
            lbInterestType.Name = "lbInterestType";
            lbInterestType.Size = new System.Drawing.Size(144, 15);
            lbInterestType.TabIndex = 4;
            lbInterestType.Text = "Interest payment method:";
            // 
            // TermInput
            // 
            TermInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            TermInput.Location = new System.Drawing.Point(161, 91);
            TermInput.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            TermInput.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            TermInput.Name = "TermInput";
            TermInput.Size = new System.Drawing.Size(63, 23);
            TermInput.TabIndex = 3;
            TermInput.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lbTerm
            // 
            lbTerm.AutoSize = true;
            lbTerm.Font = new System.Drawing.Font("Segoe UI", 9F);
            lbTerm.Location = new System.Drawing.Point(11, 93);
            lbTerm.Name = "lbTerm";
            lbTerm.Size = new System.Drawing.Size(89, 15);
            lbTerm.TabIndex = 2;
            lbTerm.Text = "Term (months):";
            // 
            // AmountInput
            // 
            AmountInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            AmountInput.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            AmountInput.Location = new System.Drawing.Point(160, 27);
            AmountInput.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            AmountInput.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            AmountInput.Name = "AmountInput";
            AmountInput.Size = new System.Drawing.Size(120, 23);
            AmountInput.TabIndex = 1;
            AmountInput.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lbDepositAmount
            // 
            lbDepositAmount.AutoSize = true;
            lbDepositAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            lbDepositAmount.Location = new System.Drawing.Point(10, 29);
            lbDepositAmount.Name = "lbDepositAmount";
            lbDepositAmount.Size = new System.Drawing.Size(95, 15);
            lbDepositAmount.TabIndex = 0;
            lbDepositAmount.Text = "Deposit amount:";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new System.Drawing.Point(20, 215);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new System.Drawing.Size(75, 23);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = " Calculate ";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lbIncome
            // 
            lbIncome.AutoSize = true;
            lbIncome.Location = new System.Drawing.Point(65, 254);
            lbIncome.Name = "lbIncome";
            lbIncome.Size = new System.Drawing.Size(0, 15);
            lbIncome.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(15, 254);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(50, 15);
            label1.TabIndex = 3;
            label1.Text = "Income:";
            // 
            // CalculatorForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(460, 286);
            Controls.Add(label1);
            Controls.Add(lbIncome);
            Controls.Add(btnCalculate);
            Controls.Add(groupBox1);
            Name = "CalculatorForm";
            Text = "Deposit Calculator";
            Load += CalculatorForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RateInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)TermInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)AmountInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown AmountInput;
        private System.Windows.Forms.Label lbDepositAmount;
        private System.Windows.Forms.NumericUpDown TermInput;
        private System.Windows.Forms.Label lbTerm;
        private System.Windows.Forms.Label lbInterestType;
        private System.Windows.Forms.ComboBox cbCurrency;
        private System.Windows.Forms.Label lbCurrencies;
        private System.Windows.Forms.ComboBox cbInterestType;
        private System.Windows.Forms.Label lbRate;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.NumericUpDown RateInput;
        private System.Windows.Forms.Label lbIncome;
        private System.Windows.Forms.Label label1;
    }
}
