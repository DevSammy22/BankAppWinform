using BusinessLogic;
using Microsoft.Extensions.DependencyInjection;
using Models;
using Storage;
using System;
using System.Windows.Forms;
using WindowFormsBankApp;

namespace NationalBankForm
{
    public partial class DashBoard : Form
    {
        readonly IServiceProvider _serviceProvider;
        readonly IAuthentication _authetication;
        readonly IAccountLogic _accountLogic;
        Account account;

        public DashBoard(IServiceProvider serviceProvider, IAuthentication authentication, IAccountLogic accountLogic)
        {   _serviceProvider = serviceProvider;
            _authetication = authentication;
            _accountLogic = accountLogic;
            account = AccountStorage.GetLoggedInAccount(Authentication.LogInCustomer.Id);
            InitializeComponent();
        }

        private void btnNewAccount_Click(object sender, EventArgs e)
        {
            Hide();
            NewAccount newAccount = _serviceProvider.GetService<NewAccount>();
            newAccount.Show();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Deposit deposit = _serviceProvider.GetRequiredService<Deposit>();
            deposit.ShowDialog();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
           // this.Hide();
            Withdrawal withdraw = _serviceProvider.GetRequiredService<Withdrawal>();
            withdraw.ShowDialog();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Transfer transfer = _serviceProvider.GetRequiredService<Transfer>();
            transfer.ShowDialog();
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //balance.Text = _accountLogic.GetBalance(accountNumber).ToString();
            //balance.Show();
        }

        private void btnAccountDetails_Click(object sender, EventArgs e)
        {
            //this.Hide();
            AccountDetails accountdetails = _serviceProvider.GetRequiredService<AccountDetails>();
            accountdetails.ShowDialog();
        }

        private void btnAccountStatement_Click(object sender, EventArgs e)
        {
            //this.Hide();
            AccoutStatement accoutStatement = _serviceProvider.GetRequiredService<AccoutStatement>();
            accoutStatement.ShowDialog();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            lblAccNumber.Text = account.AccountNumber;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginAndRegForm loginAndRegForm = _serviceProvider.GetRequiredService<LoginAndRegForm>();
            loginAndRegForm.Show();
        }

    }
}
