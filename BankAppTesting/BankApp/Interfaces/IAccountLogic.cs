using Models;

namespace BusinessLogic
{
    public interface IAccountLogic
    {
        Account AccountCreation(string customerId, string accountName, string accountType, string accountNumber, decimal balance, string dateCreated);
        decimal GetBalance(string accountNumber);
        string AccountNumberGenerator();
    }
}