//using BusinessLogic;
//using Models;
//using System;
//using Xunit;

//namespace BankAppTestProject
//{
//    public class AccountLogicTest
//    {
//        private AccountLogic _accountLogic;

//        public AccountLogicTest()
//        {
//            _accountLogic = new AccountLogic();
//        }


//        [Fact]
//        public void ShouldGenerateAccountNumber()
//        {
//            //Arrange
//            int expected = 10;
//            string startWith = "21";

//            //Act
//            string accountNo = _accountLogic.AccountNumberGenerator();
            
//            //Assert
//            Assert.Equal(expected, accountNo.Length);
//            Assert.StartsWith(startWith, accountNo);
//            Assert.NotNull(accountNo);

//        }

//        //[Theory]
//        //[InlineData()]
//        //public void ShouldGetBalance(Account account, Account expected)
//        //{
//        //    //Arrange
//        //    //Act
//        //    //Assert

//        //}

//        [Fact]
//        public void ShouldCreateAccountNum()
//        {
//            //int expected = 
//        }
//    }
//}
