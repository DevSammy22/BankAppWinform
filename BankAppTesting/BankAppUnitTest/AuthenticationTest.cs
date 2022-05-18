using BusinessLogic;
using Models;
using Storage;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BankAppUnitTest
{
    public class AuthenticationTest
    {
        [Theory]
        [InlineData("Sam", "Ade", "samadedeji@yahoo.com", "Holiness1@", "Savings", true)]
        [InlineData("sam", "ade", "paul,kelvin@yahoo.com", "mid11", "Savings", false)]
        public void ShouldRegisterCustomer(string firstName, string lastName, string email, string password, string accountType, bool expected)
        {
            //Arrange
            Authentication authentication = new Authentication();
            
            //Act
            var actual = authentication.Registration(firstName, lastName, email, password, accountType);

            //Assert
            Assert.NotNull(CustomerStorage.customers);
            Assert.Contains(CustomerStorage.customers, actual => actual.FirstName == firstName && actual.LastName == lastName);
        }


        [Theory]
        [InlineData("sam@gmail.com", "Holiness1@", true)]
        [InlineData("paul", "43yh", false)]
        public void ShouldLogin(string email, string password, bool expected)
        {
            //Arrange
            Authentication authentication = new Authentication();
            Customer customer = new Customer("6797a1a5 - f3c0 - 4bfc - b480 - 6cec64737743", "Sam", "Ade", "sam@gmail.com", "Holiness1@", DateTime.Now.ToString());
            CustomerStorage.customers.Add(customer);
            //Act
            var actual = authentication.Login(email, password);

            //Assert
            Assert.Equal(expected, actual);
        }

       [Fact]
        public void ShouldLogout()
        {
            //Arrange
            bool expected = true;

            //Act
            Authentication authentication = new Authentication();
            var actual = authentication.Logout();

            //Assert
            Assert.Equal(expected, actual);
        } 
    }
}
