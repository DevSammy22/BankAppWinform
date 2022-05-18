namespace BusinessLogic
{
    public interface ITransactionLogic
    {
        bool Deposit(decimal amount, string accountNumber, string transactionDescription);
        bool Transfer(decimal amount, string depositorAccountNumber, string receipientAccountNumber, string transactionDescription);
        bool Withdraw(decimal amount, string accountNumber, string transactionDescription);
    }
}