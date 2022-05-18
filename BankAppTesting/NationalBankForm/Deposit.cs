using BusinessLogic;
using Microsoft.Extensions.DependencyInjection;
using Models;
using Repository;
using Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Utilities;
using WindowFormsBankApp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NationalBankForm
{
    public partial class Deposit : Form
    {
        public static string accountNumber;
        public static string amount;
        public static string description;

        readonly IValidation _validation;
        readonly IAccountLogic _accountLogic;
        readonly ITransactionLogic _transactionLogic;
        readonly IAccountRepository _accountRepository;
        readonly IServiceProvider _serviceProvider;
        Account account;

        public Deposit(IValidation validation, IAccountLogic accountLogic, ITransactionLogic transactionLogic, IAccountRepository accountRepository, IServiceProvider serviceProvider)
        {
            _validation = validation;
            _accountLogic = accountLogic;
            _transactionLogic = transactionLogic;
            _accountRepository = accountRepository;
            _serviceProvider = serviceProvider;
            account = AccountStorage.GetLoggedInAccount(Authentication.LogInCustomer.Id);
            InitializeComponent();
        }

        
    private void lblSubmitDeposit_Click(object sender, EventArgs e)
        {
            accountNumber = txtAccNumDeposit.Text;

            amount = txtAmountDeposit.Text;
            description = txtDescriptionDeposit.Text;

            if (_validation.AcctNumValidator(accountNumber) || (_accountRepository.GetAccountDetails(accountNumber) !=null))
            {
                if (_validation.AmountValidator(amount) && amount.Length <= 15)
                {
                    decimal amountInput = Convert.ToDecimal(amount);
                    if (_transactionLogic.Deposit(amountInput, accountNumber, description))
                    {
                        MessageBox.Show($"Your deposit of {amount} was succesful!");
                        this.Hide();
                        DashBoard dashboard = _serviceProvider.GetRequiredService<DashBoard>();
                        dashboard.Show();
                    }
                    else
                    {
                        MessageBox.Show("Unsuccessful transaction!");
                        this.Hide();
                        DashBoard dashboard = _serviceProvider.GetRequiredService<DashBoard>();
                        dashboard.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid input. Amount must be greater zero.");
                }
            }
            else
            {
                    MessageBox.Show("Unregisterd account number.");
            }
        }

        private void lblGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashBoard dashboard = _serviceProvider.GetRequiredService<DashBoard>();
            dashboard.Show();
        }

        private void Deposit_Load(object sender, EventArgs e)
        {
            txtAccNumDeposit.Text = account.AccountNumber;
        }
    }
}
