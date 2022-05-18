using BusinessLogic;
using Microsoft.Extensions.DependencyInjection;
using NationalBankForm;
using System;
using System.Windows.Forms;
using Utilities;

namespace WindowFormsBankApp
{
    public partial class LoginAndRegForm : Form
    {
        readonly IValidation _validation;
        readonly IServiceProvider _serviceProvider;
        readonly IAuthentication _authentication;
        private readonly IAccountLogic _accountLogic;


        public LoginAndRegForm(IValidation validation, IServiceProvider serviceProvider, IAuthentication authentication, IAccountLogic accountLogic)
        {
            _validation = validation;
            _serviceProvider = serviceProvider;
            _authentication = authentication;
            _accountLogic = accountLogic;
            InitializeComponent();
        }

        public static string fName;
        public static string lName;
        public static string email;
        public static string accType;
        public static string password;
        public static string accountNumber;
        public static string dateCreated = DateTime.Now.ToString();

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
             email = textBox1.Text;
             password = textBox2.Text;
            
            if(_validation.EmailValidator(email) && _validation.PasswordValidator(password))
            {
                var check = _authentication.Login(email, password);
                if (check)
                {
                    MessageBox.Show("Your login is successful");
                    //this.Hide();
                    DashBoard dashboard = _serviceProvider.GetRequiredService<DashBoard>();
                    dashboard.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid Email or Password");
                }
            }
            else
            {
                MessageBox.Show("Invalid Email or Password");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PanelRight.Left = 44;
            PanelLeft.Left = 588;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            PanelRight.Left = 588;     
            PanelLeft.Left = 44;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            fName = textBox6.Text;
            lName = textBox5.Text;
            email = textBox4.Text;
            accType = comboBox1.Text;
            password = textBox3.Text;

            if (_validation.EmailValidator(email))
            {
                if (_validation.PasswordValidator(password))
                {
                    if (_validation.NameValidator(fName))
                    {
                        if (_validation.NameValidator(lName))
                        {
                            accountNumber = _accountLogic.AccountNumberGenerator();
                            var customer = _authentication.Registration(fName, lName, email, password, accType);
                            _accountLogic.AccountCreation(customer.Id, customer.FirstName + " " + customer.LastName, accType, accountNumber, 0M, dateCreated);
                            MessageBox.Show($"The {accType} Account Number {accountNumber} Has Been Created Successfuly");
                            //this.Hide();
                            Confirmation confirmation = _serviceProvider.GetRequiredService<Confirmation>();
                            confirmation.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Invalid name. Name must start with capital letter.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid name. Name must start with capital letter.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid password. Password should be minimum of 6 characters that include" +
                        "alphanumeric and at least one special characters (@,$,!,%,*,#,?,&,!,^,.)");
                }
                   
            }
                else
                {
                    MessageBox.Show("Invalid email.");
                }
        }

        private void lblexit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

