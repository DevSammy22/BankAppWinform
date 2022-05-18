using Models;
using Repository;
using Storage;
using System;
using System.Linq;
namespace BusinessLogic
{
    public class AccountLogic : IAccountLogic
    {
        public IAccountRepository _accountRepository;
        public AccountLogic(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public AccountLogic()
        {
        }
        public string AccountNumberGenerator()
        {
            Random randomNumber = new Random();
            string accountNumber = "21";
            return accountNumber + randomNumber.Next(11111111, 99999999);
        }
        public decimal GetBalance(string accountNumber)
        {
            Account account = _accountRepository.GetAccountDetails(accountNumber);
            if (account != null)
            {
                return account.Balance;
            }
            else
            {
                return -1;
            }
        }
        public Account AccountCreation(string customerId, string accountName, string accountType, string accountNumber, decimal balance, string dateCreated)
        {
            Account account = new Account(customerId, accountName, accountType.ToString(), accountNumber, balance, dateCreated);
            {
                try
                {
                    _accountRepository.AddAccount(account);
                    AccountStorage.SaveAccountToFile().GetAwaiter().GetResult();
                    return account;
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
    }
}
