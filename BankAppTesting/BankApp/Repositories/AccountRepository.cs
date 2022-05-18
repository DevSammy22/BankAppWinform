using Models;
using Storage;
using System.Linq;

namespace Repository
{
    public class AccountRepository : IAccountRepository
    {
        public Account GetAccountDetails(string accountNumber)
        {
            Account accountDetails = AccountStorage.accounts.FirstOrDefault(x => x.AccountNumber == accountNumber);
            return accountDetails;
        }

        public void AddAccount(Account account)
        {
            AccountStorage.accounts.Add(account);
        }
    }
}
