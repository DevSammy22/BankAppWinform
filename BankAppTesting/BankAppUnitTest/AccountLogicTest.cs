using BusinessLogic;
using Models;
using Moq;
using Repository;
using Storage;
using System;
using Xunit;

namespace BankAppTestProject
{
    public class AccountLogicTest
    {
        private AccountLogic _accountLogic;

        public AccountLogicTest()
        {
            _accountLogic = new AccountLogic();
        }

        [Fact]
        public void ShouldGenerateAccountNumber()
        {
            //Arrange
            int expected = 10;
            string startWith = "21";

            //Act
            string accountNo = _accountLogic.AccountNumberGenerator();

            //Assert
            Assert.Equal(expected, accountNo.Length);
            Assert.StartsWith(startWith, accountNo);
            Assert.NotNull(accountNo);
        }

        [Fact]
        public void ShouldGetBalance()
        {
            //Arrange
            var accountRepository = new Mock<AccountRepository>();
            AccountLogic accountLogic = new AccountLogic(accountRepository.Object);
            Account result = new Account("6797a1a5 - f3c0 - 4bfc - b480 - 6cec64737743", "Sam Ade", "Savings", "2174327257", 500M, DateTime.Now.ToString());
            AccountStorage.accounts.Add(result);
            var expected = 500M;
            
            //Act
            var actual = accountLogic.GetBalance("2174327257");
            
            //Assert
            Assert.Equal(expected, actual);
            Assert.IsType<decimal>(actual);
        }


        [Fact]
        public void ShouldCreateAccountNum()
        {
            //Arrange
            var accountRepository = new Mock<AccountRepository>();
            AccountLogic accountLogic = new AccountLogic(accountRepository.Object);
            var expected = AccountStorage.accounts;

            //Act
            var actual =accountLogic.AccountCreation("6797a1a5 - f3c0 - 4bfc - b480 - 6cec64737743", "Sam Ade", "Savings", "2174327257", 500M, DateTime.Now.ToString());

            //Assert
            Assert.NotNull(expected);
            Assert.Contains(expected, actual => actual.AccountNumber == "2174327257");
        }
    }
}
