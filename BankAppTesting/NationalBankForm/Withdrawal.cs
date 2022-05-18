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

namespace NationalBankForm
{
    public partial class Withdrawal : Form
    {
        string accountNumber;
        decimal amount;
        string description;
        readonly IValidation _validation;
        readonly ITransactionLogic _transactionLogic;
        readonly IAccountRepository _accountRepository;
        readonly IServiceProvider _serviceProvider;
        Account account;


        public Withdrawal(IValidation validation, ITransactionLogic transactionLogic, IAccountRepository accountRepository, IServiceProvider serviceProvider)
        {
            _validation = validation;
            _transactionLogic = transactionLogic;
            _accountRepository = accountRepository;
            _serviceProvider = serviceProvider;
            account = AccountStorage.GetLoggedInAccount(Authentication.LogInCustomer.Id);
            InitializeComponent();
        }

        private void lblSubmitWithdrawal_Click(object sender, EventArgs e)
        {
            accountNumber = txtAccNumWithdrawal.Text;
            amount = Convert.ToDecimal(txtAmountWithdrawal.Text);
            description = txtDescriptionWithdrawal.Text;

            if (_validation.AcctNumValidator(accountNumber) || _accountRepository.GetAccountDetails(accountNumber) != null)
            {
                if (_validation.AmountValidator(amount.ToString()))
                {
                    if (_transactionLogic.Withdraw(amount, accountNumber, description))
                    {
                        MessageBox.Show($"Your account has been debited with { amount }");
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

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashBoard dashboard = _serviceProvider.GetRequiredService<DashBoard>();
            dashboard.Show();
        }

        private void Withdrawal_Load(object sender, EventArgs e)
        {
            txtAccNumWithdrawal.Text = account.AccountNumber;
        }
    }
}
