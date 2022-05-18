using System;

namespace Models
{
    public class Transaction
    {
        public string CustomerId { get; set; }
        public decimal Amount { get; set; }
        public string  AccountNumber { get; set; }
        public string TransactionType { get; set; }
        public string TransactionDescription { get; set; }
        public decimal Balance { get; set; }
        public string DateCreated { get; set; }

        public Transaction(string customerId, decimal amount, string accountNumber, string transactionType, string dateCreated, string transactionDescription, decimal balance)
        {
            CustomerId = customerId;
            Amount = amount;
            AccountNumber = accountNumber;
            TransactionType = transactionType;
            TransactionDescription = transactionDescription;
            Balance = balance;
            DateCreated = dateCreated;
        }

    }
}
