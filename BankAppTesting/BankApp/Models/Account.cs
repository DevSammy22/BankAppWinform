using System;

namespace Models
{
    public class Account
    {
        public string CustomerId { get; set; }
        public string AccountNumber { get; set; }
        public string AccountType { get; set; }
        public decimal Balance { get; set; }
        public string DateCreated { get; set; }
        public string AccountName { get; set; }

        //public Customer Customer { get; set; }

        public Account(string customerId, string accountName, string accountType, string accountNumber,decimal balance, string dateCreated)
        {
            CustomerId = customerId;
            AccountName = accountName;
            AccountNumber = accountNumber;
            AccountType = accountType;
            Balance = balance;
            DateCreated = dateCreated;
            //Customer = customer;
        }

    }
}