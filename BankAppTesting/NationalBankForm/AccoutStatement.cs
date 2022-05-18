using BusinessLogic;
using Microsoft.Extensions.DependencyInjection;
using Models;
using Storage;
using System;
using System.Windows.Forms;
using WindowFormsBankApp;

namespace NationalBankForm
{
    public partial class AccoutStatement : Form
    {
        readonly IServiceProvider _serviceProvider;
        readonly IAccountLogic _accountLogic;
        Account account;
        string accountNumber;

        public AccoutStatement(IServiceProvider serviceProvider, IAccountLogic accountLogic)
        {
            _serviceProvider = serviceProvider;
            _accountLogic = accountLogic;
            account = AccountStorage.GetLoggedInAccount(Authentication.LogInCustomer.Id);
            InitializeComponent();
        }
        
        private void AccoutStatement_Load(object sender, EventArgs e)
        {
            Transaction transaction = TransactionStorage.GetCustomerTransaction(account.AccountNumber);
            accountNumber = account.AccountNumber;
            lblAccNumSta.Text = accountNumber;
            lblAmtSta.Text = transaction.Amount.ToString();
            lblBal.Text = account.Balance.ToString();
            lblDate.Text = account.DateCreated;
        }

        private void btnContinueAccSta_Click(object sender, EventArgs e)
        {
            //this.Dispose();
            DashBoard dashBoard = _serviceProvider.GetRequiredService<DashBoard>();
            dashBoard.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Dispose();
            DashBoard dashBoard = _serviceProvider.GetRequiredService<DashBoard>();
            dashBoard.Show();
        }
    }
}
