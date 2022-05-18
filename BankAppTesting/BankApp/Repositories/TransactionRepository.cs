using Models;
using Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class TransactionRepository : ITransactionRepository
    {
        public List<Transaction> GetAccountStatement(string accountNumber)
        {
            List<Transaction> accountStatement = TransactionStorage.transactions.Where(x => x.AccountNumber == accountNumber).ToList();
            return accountStatement;
        }

        public void AddTransaction(Transaction transaction)
        {
            TransactionStorage.transactions.Add(transaction);
        }

    }
}
