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
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utilities;

namespace NationalBankForm
{
    public partial class Transfer : Form
    {
        readonly IValidation _validation;
        readonly ITransactionLogic _transactionLogic;
        readonly IAccountRepository _accountRepository;
        readonly IServiceProvider _serviceProvider;
        Account account;


        public Transfer(IValidation validation, ITransactionLogic transactionLogic, IAccountRepository accountRepository, IServiceProvider serviceProvide)
        {
            _validation = validation;
            _transactionLogic = transactionLogic;
            _accountRepository = accountRepository;
            _serviceProvider = serviceProvide;
            account = AccountStorage.GetLoggedInAccount(Authentication.LogInCustomer.Id);
            InitializeComponent();
        }

        private void lblSubmitTransfer_Click(object sender, EventArgs e)
        {
            string senderAccountNumber = txtAccNumSender.Text;
            string receipientAccountNumber = txtAccNumReceiver.Text;
            decimal amount = Convert.ToDecimal(txtAmountTransfer.Text);
            string description = txtDescriptionTransfer.Text;

            if (_validation.AcctNumValidator(senderAccountNumber) == false || _accountRepository.GetAccountDetails(senderAccountNumber) == null)
            {
                if (_validation.AcctNumValidator(receipientAccountNumber) == false || _accountRepository.GetAccountDetails(receipientAccountNumber) == null)
                {
                    if (_validation.AmountValidator(amount.ToString()) == false)
                    {
                        var myTransfer = AccountStorage.accounts.FirstOrDefault(x => x.AccountNumber == senderAccountNumber);
                        if (myTransfer == null)
                        {
                            MessageBox.Show("Invalid Account Number");
                        }
                        else if (myTransfer.AccountType == AccountType.Savings.ToString() && myTransfer.Balance - amount < 1000)
                        {
                            MessageBox.Show("Insufficient Balance");
                        }
                        else if (myTransfer.AccountType == AccountType.Current.ToString() && myTransfer.Balance - amount < 0)
                        {
                            MessageBox.Show("Insufficient Balance");
                        }
                        else
                        {
                            if (_transactionLogic.Transfer(amount, senderAccountNumber, receipientAccountNumber, description) == true)
                            {
                                MessageBox.Show("Your transaction was successfull");
                                this.Hide();
                                DashBoard dashboard = _serviceProvider.GetRequiredService<DashBoard>();
                                dashboard.Show();
                            }
                            else
                            {
                                MessageBox.Show("The recipient account number is not found");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sorry, invalid input. \nAmount must be greater than zero(0)");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Sorry, invalid input or unregistered account number. \nAccount number must be ten (10) digits and registered");
                }
            }
            else
            {
                MessageBox.Show("Sorry, invalid input or unregistered account number. \nAccount number must be ten (10) digits and registered");
            }
        }

        private void Transfer_Load(object sender, EventArgs e)
        {
            txtAccNumSender.Text = account.AccountNumber;
        }
    }
}
