using BusinessLogic;
using Microsoft.Extensions.DependencyInjection;
using Repository;
using System;
using System.Collections.Generic;
using UserInterface;

namespace BankApp
{
    public class Program
    {
       
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddScoped<IAccountRepository, AccountRepository>()
                .AddScoped<ICustomerRepository, CustomerRepository>()
                .AddScoped<ITransactionRepository, TransactionRepository>()
                .AddScoped<IAccountLogic, AccountLogic>()
                .AddScoped<ITransactionLogic, TransactionLogic>()
                .AddScoped<IAuthentication, Authentication>()
                .BuildServiceProvider();

            var display = serviceProvider.GetRequiredService<IUserDisplay>();
            display.Welcome();
        }
    }
}
