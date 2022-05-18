using BusinessLogic;
using Models;
using Moq;
using Repository;
using Xunit;
using System;
using Storage;

namespace BankAppUnitTest
{
    public class TransactionLogicTest
    {
        private readonly Mock<ITransactionRepository> _transactionRepository;

        public TransactionLogicTest()
        {
            _transactionRepository = new Mock<ITransactionRepository>();
        }

        [Theory]
        [InlineData(500,"1234567891", "USSD", true)]
        [InlineData(2500,"0987654321", "Tfare", false)]
        
        public void ShouldDepositAmount(decimal amount, string accountNumber, string description, bool expected)
        {
            //Arrange
            TransactionLogic transactionLogic = new TransactionLogic(_transactionRepository.Object);
            Account result = new Account("6797a1a5 - f3c0 - 4bfc - b480 - 6cec64737743", "Sam Ade", "Savings", "1234567891", 500, DateTime.Now.ToString());
            AccountStorage.accounts.Add(result);
            //Act
            var actual = transactionLogic.Deposit(amount, accountNumber, description);

            //Assert
            Assert.Equal(expected, actual);
            Assert.IsType<bool>(actual);
        }

        [Theory]
        [InlineData(3000, "1234567890", "USSD", true)]
        [InlineData(2000, "0987654321", "Tfare", false)]
        public void ShouldWithdrawAmount(decimal amount, string accountNumber, string description, bool expected)
        {
            //Arrange
            TransactionLogic transactionLogic = new TransactionLogic(_transactionRepository.Object);
            Account result = new Account("6797a1a5 - f3c0 - 4bfc - b480 - 6cec64737743", "Sam Ade", "Savings", "1234567890", 5000, DateTime.Now.ToString());
            AccountStorage.accounts.Add(result);

            //Act
            var actual = transactionLogic.Withdraw(amount, accountNumber, description);

            //Assert
            Assert.Equal(expected, actual);
            Assert.IsType<bool>(actual);
        }

        [Theory]
        [InlineData(3000, "1234567890", "1234567810", "USSD", true)]
        [InlineData(2000, "0987654321", "0987654311", "Tfare", false)]
        public void ShouldTransferAmount(decimal amount, string depositorAccountNumber, string receipientAccountNumber, string transactionDescription, bool expected)
        {
            //Arrange
            TransactionLogic transactionLogic = new TransactionLogic(_transactionRepository.Object);
            Account account1 = new Account("6797a1a5 - f3c0 - 4bfc - b480 - 6cec64737743", "Sam Ade", "Savings", "1234567890", 5000, DateTime.Now.ToString());
            AccountStorage.accounts.Add(account1);
            Account account2 = new Account("6797a1a5 - f3c0 - 4bfc - b500 - 6cec64737743", "Sam Hoe", "Current", "1234567810", 1000, DateTime.Now.ToString());
            AccountStorage.accounts.Add(account2);
            //Act
            var actual = transactionLogic.Transfer(amount, depositorAccountNumber, receipientAccountNumber, transactionDescription);

            //Assert
            Assert.Equal(expected, actual);
            Assert.IsType<bool>(actual);
        }
    }
}
