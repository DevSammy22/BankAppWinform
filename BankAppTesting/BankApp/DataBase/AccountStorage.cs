using Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Storage
{
    public class AccountStorage
    {
        public static List<Account> accounts = new List<Account>();
        readonly static string accountFilePath = "AccountStorage.csv";

        public static async Task SaveAccountToFile()
        {
            List<string> accountFileStorage = new List<string>(); 
            foreach (var account in accounts)
            {
                string accountDetails = $"{account.AccountName},{account.AccountNumber},{account.AccountType},{account.DateCreated},{account.Balance},{account.CustomerId},";
                accountFileStorage.Add(accountDetails);
            }
            await File.WriteAllLinesAsync(accountFilePath, accountFileStorage);
        }

        public static void GetAccountFromFile()
        {
            if (File.Exists(accountFilePath))
            {
                using StreamReader reader = new StreamReader(accountFilePath);
                string line = reader.ReadLine();
                while (line != null)
                {
                    string[] accountDetails = line.Split(',');
                    string accountName = accountDetails[0];
                    string accountNumber = accountDetails[1];
                    string accountType = accountDetails[2];
                    string dateCreated = accountDetails[3];
                    decimal balance = Convert.ToDecimal(accountDetails[4]);
                    string customerId = accountDetails[5];

                    Account accountFromFile = new Account(customerId, accountName, accountType, accountNumber, balance, dateCreated);
                    accounts.Add(accountFromFile);
                }
            }
        }

        public static Account GetLoggedInAccount(string customerId)
        {
            var account = accounts.FirstOrDefault(x => x.CustomerId == customerId);
            return account;
        }
    }
}
