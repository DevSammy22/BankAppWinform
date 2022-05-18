using Models;
using System.Collections.Generic;

namespace Repository
{
    public interface ITransactionRepository
    {
        void AddTransaction(Transaction transaction);
        List<Transaction> GetAccountStatement(string accountNumber);
    }
}