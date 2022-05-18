using BankAppTestProject;
using BankAppUnitTest;
using BusinessLogic;
using Microsoft.Extensions.DependencyInjection;
using Repository;
using Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInterface;
using Utilities;
using WindowFormsBankApp;

namespace NationalBankForm
{
    public class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CustomerStorage.GetCustomerFromFile();
            AccountStorage.GetAccountFromFile();
            TransactionStorage.GetTransactionFromFile();

            ServiceCollection service = new ServiceCollection();
            ConfigureServices(service);
            using ServiceProvider serviceProvider = service.BuildServiceProvider();
            var loginAndRegForm = serviceProvider.GetRequiredService<LoginAndRegForm>();
            Application.Run(loginAndRegForm);
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services
                .AddScoped<IAccountRepository, AccountRepository>()
                .AddScoped<ICustomerRepository, CustomerRepository>()
                .AddScoped<ITransactionRepository, TransactionRepository>()
                .AddScoped<IAccountLogic, AccountLogic>()
                .AddScoped<ITransactionLogic, TransactionLogic>()
                .AddScoped<IAuthentication, Authentication>()
                .AddScoped<IValidation, Validation>()
                .AddScoped<LoginAndRegForm>()
                .AddScoped<Confirmation>()
                .AddScoped<DashBoard>()
                .AddScoped<Deposit>()
                .AddScoped<Withdrawal>()
                .AddScoped<Transfer>()
                .AddScoped<AccountDetails>()
                .AddScoped<AccoutStatement>()
                .AddScoped<NewAccount>()
                .BuildServiceProvider();
        }
    }
}
