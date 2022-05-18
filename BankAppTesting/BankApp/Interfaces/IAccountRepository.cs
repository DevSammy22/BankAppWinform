using Models;

namespace Repository
{
    public interface IAccountRepository
    {
        void AddAccount(Account account);
        Account GetAccountDetails(string accountNumber);
    }
}