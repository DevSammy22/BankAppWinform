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
    public partial class Confirmation : Form
    {
        
        readonly IServiceProvider _serviceProvider;
        readonly IAccountLogic _accountLogic;

        public Confirmation(IServiceProvider serviceProvider, IAccountLogic accountLogic)
        {
            _serviceProvider = serviceProvider;
            _accountLogic = accountLogic;
            InitializeComponent();
        }

        private void Confirmation_Load(object sender, EventArgs e)
        {
           label7.Text  = LoginAndRegForm.fName;
            label8.Text = LoginAndRegForm.lName;
            label9.Text = LoginAndRegForm.email;
            label10.Text = LoginAndRegForm.accType;
            lblAccNum.Text = LoginAndRegForm.accountNumber;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginAndRegForm loginAndRegForm = _serviceProvider.GetRequiredService<LoginAndRegForm>();
            loginAndRegForm.Show();
            
        }
    }
}
