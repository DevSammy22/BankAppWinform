using Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Storage
{
    public class TransactionStorage
    {
        public static List<Transaction> transactions = new List<Transaction> ();
        static string transactionFilePath = "TransactionStorage.csv";

        public static void SaveTransactionToFile(Transaction transaction)
        {
            using StreamWriter writer = new StreamWriter(transactionFilePath, true);
            string transactionDetails = $"{transaction.AccountNumber},{transaction.TransactionType},{transaction.DateCreated},{transaction.TransactionDescription},{transaction.Balance},{transaction.Amount},{transaction.CustomerId}";
            writer.WriteLine(transactionDetails);
            
        }


        public static void GetTransactionFromFile()
        {
            string line;
            if (File.Exists(transactionFilePath))
            {
                using StreamReader reader = new StreamReader(transactionFilePath);
                while ((line = reader.ReadLine()) != null)
                {
                    string[] transactionDetails = line.Split(',');
                    string accountNumber = transactionDetails[0];
                    string transactionType = transactionDetails[1];
                    string dateCreated = transactionDetails[2];
                    string transactionDescription = transactionDetails[3];
                    decimal balance = Convert.ToDecimal(transactionDetails[4]);
                    decimal amount = Convert.ToDecimal(transactionDetails[5]);
                    string customerId = transactionDetails[6];


                    var transactionFromFile = new Transaction(customerId, amount, accountNumber, transactionType, dateCreated, transactionDescription, balance);
                    transactions.Add(transactionFromFile);
                }
            }
        }

         public static Transaction GetCustomerTransaction(string accountNumber)
        {
            var transactionlist = transactions.Where(x => x.AccountNumber == accountNumber).ToList();
            return transactionlist[transactionlist.Count - 1];
        }
    }

}
