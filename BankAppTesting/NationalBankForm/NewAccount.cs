using BusinessLogic;
using Microsoft.Extensions.DependencyInjection;
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
    public partial class NewAccount : Form
    {
        IAccountLogic _accountLogic;
        IAuthentication _authentication;
        IServiceProvider _serviceProvider;

        public NewAccount(IAccountLogic accountLogic, IAuthentication authentication, IServiceProvider serviceProvider)
        {
            _accountLogic = accountLogic;
            _authentication = authentication;
            _serviceProvider = serviceProvider;
            InitializeComponent();
        }

        private void lblReg_Click(object sender, EventArgs e)
        {
            string firstName = Authentication.LogInCustomer.FirstName;
            string lastName = Authentication.LogInCustomer.LastName;
            string customerId = Authentication.LogInCustomer.Id;
            string date = DateTime.Now.ToString();
            string accType = accountType.Text;
            string accNum = _accountLogic.AccountNumberGenerator();
            _accountLogic.AccountCreation(customerId,  firstName + " " + lastName, accType, accNum, 0.0M, date);            MessageBox.Show($"The {accType} Account Number {accNum} Has Been Created Successfuly");
            MessageBox.Show($"Your New {accType} Account Number is {accNum}");
            DashBoard dashboard = _serviceProvider.GetRequiredService<DashBoard>();
            Hide();
            dashboard.Show();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            LoginAndRegForm loginAndRegForm = _serviceProvider.GetRequiredService<LoginAndRegForm>();
            loginAndRegForm.ShowDialog();
        }
    }
}
