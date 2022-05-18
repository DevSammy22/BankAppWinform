using System.Text.RegularExpressions;

namespace Utilities
{
    public class Validation : IValidation
    {

        public bool EmailValidator(string check)
        {
            string emailPattern = "^[a-zA-Z][A-Za-z0-9._]*@[a-z]+\\.[a-z]{2,3}$";
            if (Regex.IsMatch(check, emailPattern) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool PasswordValidator(string check)
        {
            string passwordPattern = "^(?=.*[A-Za-z])(?=.*\\d)(?=.*[@$!%*#?&!^.])[A-Za-z\\d@$!%*#?&.]{6,}$";
            if (Regex.IsMatch(check, passwordPattern) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool NameValidator(string check)
        {
            string namePattern = "^[A-Z]{1}[a-z]{2,}$";
            if (Regex.IsMatch(check, namePattern) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AmountValidator(string check)
        {
            string amountPattern = "^[1-9]{1}[0-9]{1,}$";
            if (Regex.IsMatch(check, amountPattern) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AcctNumValidator(string check)
        {
            string accNumValidator = "^[0-9]{10}$";
            if (Regex.IsMatch(check, accNumValidator) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool NumberCheck(string number)
        {
            if (int.TryParse(number, out _) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
