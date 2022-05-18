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
using WindowFormsBankApp;

namespace NationalBankForm
{
    public partial class AccountDetails : Form
    {

        readonly IServiceProvider _serviceProvider;

        // readonly IAccountLogic _accountLogic;
        readonly Account account;
        //Transaction transaction;

        public AccountDetails(IServiceProvider serviceProvider/*, IAccountLogic accountLogic*/)
        {
            _serviceProvider = serviceProvider;
          //  _accountLogic = accountLogic;
            account = AccountStorage.GetLoggedInAccount(Authentication.LogInCustomer.Id);
           // transaction = TransactionStorage.GetCustomerTransaction(account.AccountNumber);

            InitializeComponent();
        }

        private void AccountDetails_Load(object sender, EventArgs e)
        {
            //string accountNumber = account.AccountNumber;
           // decimal balance = _accountLogic.GetBalance(accountNumber);
            lblAccNumDetails.Text = account.AccountNumber;
            lblNameAccDetails.Text = account.AccountName;
            lblAccTypeAccNumber.Text = account.AccountType;
            lblBalAccDetails.Text = account.Balance.ToString();
                //balance.ToString();
        }

        private void btnContinueAccDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashBoard dashBoard = _serviceProvider.GetRequiredService<DashBoard>();
            dashBoard.Show();
        }
    }
}
