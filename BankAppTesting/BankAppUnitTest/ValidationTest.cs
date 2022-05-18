using System;
using System.Collections.Generic;
using System.Text;
using Utilities;
using Xunit;

namespace BankAppUnitTest
{
    public class ValidationTest
    {
        private Validation _validation;

        public ValidationTest()
        {
            _validation = new Validation();
        }


        [Theory]
        [InlineData("sam@gmail.com", true)]
        [InlineData("sam.ade@yahoo.com", true)]
        [InlineData("samadedeji@yahoo.com", true)]
        [InlineData("paulkelvin@company.com", true)]
        [InlineData("paul.kelvin.company.com", false)]
        [InlineData("paul,kelvin@yahoo.com", false)]
        [InlineData("paul.com", false)]
        [InlineData("paul", false)]
        [InlineData("", false)]

        public void ShouldValidateEmail(string email, bool expected)
        {
            //Arrange

            //Act
            bool actual = _validation.EmailValidator(email);

            //Assert
            Assert.Equal(expected, actual);
            Assert.IsType<bool>(actual);
        }

        [Theory]
        [InlineData("Holiness1@", true)]
        [InlineData("Katemed1.", true)]
        [InlineData("paulke11!", true)]
        [InlineData("neda1.", true)]
        [InlineData("mid11", false)]
        [InlineData("ndia#", false)]
        [InlineData("", false)]

        public void ShouldValidatePassword(string password, bool expected)
        {
            //Arrange

            //Act

            var actual = _validation.PasswordValidator(password);

            //Assert
            Assert.Equal(expected, actual);
            Assert.Matches(expected.ToString(), actual.ToString());
            Assert.IsType<bool>(actual);
        }

        [Theory]
        [InlineData("Samuel", true)]
        [InlineData("samuel", false)]
        [InlineData("1234", false)]
        [InlineData("23sam", false)]
        [InlineData("", false)]

        public void ShouldValidateName(string name, bool expected)
        {
            //Arrange

            //Act
            var actual = _validation.NameValidator(name);

            //Assert
            Assert.Equal(expected, actual);
            Assert.IsType<bool>(actual);
        }

        [Theory]
        [InlineData("1000", true)]
        [InlineData("100", true)]
        [InlineData("0", false)]
        [InlineData("1mw", false)]

        public void ShouldValidateAmount(string amount, bool expected)
        {
            //Arrange

            //Act
            var actual = _validation.AmountValidator(amount);

            //Assert
            Assert.Equal(expected, actual);
            Assert.IsType<bool>(actual);
        }

        [Theory]
        [InlineData("2121234567", true)]
        [InlineData("2134567", false)]
        [InlineData("", false)]
        public void ShouldValidateAccountNumber(string accNumber, bool expected)
        {
            //Arrange

            //Act
            var actual = _validation.AcctNumValidator(accNumber);

            //Assert
            Assert.Equal(expected, actual);
            Assert.IsType<bool>(actual);
            Assert.StartsWith(expected.ToString(), actual.ToString());
        }

        [Theory]
        [InlineData("1", true)]
        [InlineData("et", false)]
        [InlineData("", false)]
        public void ShouldValidateNumberEntry(string userInput, bool expected)
        {
            //Arrange

            //Act
            var actual = _validation.NumberCheck(userInput);

            //Assert
            Assert.Equal(expected, actual);
            Assert.IsType<bool>(actual);
        }
    }
}
