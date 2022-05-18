using Models;
using Repository;
using Storage;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogic
{
    public class TransactionLogic : ITransactionLogic
    {
        public ITransactionRepository _transactionRepository;
        
        public TransactionLogic(ITransactionRepository transactionRepository)
        {
            _transactionRepository = transactionRepository;
        }

        readonly string customerId = Guid.NewGuid().ToString();
        readonly string dateCreated = DateTime.Now.ToString();

        public bool Deposit(decimal amount, string accountNumber, string transactionDescription)
        {
            Account account = AccountStorage.accounts.FirstOrDefault(x => x.AccountNumber == accountNumber);
            if (account != null)
            {
                account.Balance += amount;
                Transaction transaction = new Transaction(customerId, amount, accountNumber, TransactionType.Credit.ToString(), dateCreated, transactionDescription, account.Balance);
                _transactionRepository.AddTransaction(transaction);
                TransactionStorage.SaveTransactionToFile(transaction);
                AccountStorage.SaveAccountToFile().GetAwaiter();
                return true;
            }
            return false;
        }

        public bool Withdraw(decimal amount, string accountNumber, string transactionDescription)
        {
            var account = AccountStorage.accounts.FirstOrDefault(x => x.AccountNumber == accountNumber);

            if (account != null)
            {
                if (account.AccountType == AccountType.Savings.ToString())
                {
                    if (account.Balance > 1000 && (account.Balance - amount >= 1000))
                    {
                        account.Balance -= amount;
                        Transaction transaction = new Transaction(customerId, amount, accountNumber, TransactionType.Debit.ToString(), dateCreated, transactionDescription, account.Balance);
                        _transactionRepository.AddTransaction(transaction);
                        TransactionStorage.SaveTransactionToFile(transaction);
                        AccountStorage.SaveAccountToFile().GetAwaiter();
                        return true;
                    }
                    return false;
                }
                else
                {
                    if (account.Balance >= 0 && (account.Balance - amount >= 0))
                    {
                        account.Balance -= amount;
                        Transaction transaction = new Transaction(customerId, amount, accountNumber, TransactionType.Debit.ToString(), dateCreated, transactionDescription, account.Balance);
                        _transactionRepository.AddTransaction(transaction);
                        TransactionStorage.SaveTransactionToFile(transaction);
                        AccountStorage.SaveAccountToFile().GetAwaiter().GetResult();
                        return true;
                    }

                    return false;
                }
            }
            return false;
        }

        public bool Transfer(decimal amount, string depositorAccountNumber, string receipientAccountNumber, string transactionDescription)
        {
            var depositorAccount = AccountStorage.accounts.FirstOrDefault(x => x.AccountNumber == depositorAccountNumber);
            var receipientAccount = AccountStorage.accounts.FirstOrDefault(x => x.AccountNumber == receipientAccountNumber);

            if (depositorAccount != null)
            {
                if (receipientAccount != null)
                {
                    receipientAccount.Balance += amount;
                    depositorAccount.Balance -= amount;
                    Transaction transaction1 = new Transaction(customerId, amount, depositorAccountNumber, TransactionType.Debit.ToString(), dateCreated, transactionDescription, depositorAccount.Balance);
                    Transaction transaction2 = new Transaction(customerId, amount, receipientAccountNumber, TransactionType.Credit.ToString(), dateCreated, transactionDescription, receipientAccount.Balance);

                    _transactionRepository.AddTransaction(transaction1);
                    TransactionStorage.SaveTransactionToFile(transaction1);
                    _transactionRepository.AddTransaction(transaction2);
                    TransactionStorage.SaveTransactionToFile(transaction2);
                    AccountStorage.SaveAccountToFile().GetAwaiter().GetResult();
                    return true;
                }
                return false;
            }
            return false;
        }
    }
}