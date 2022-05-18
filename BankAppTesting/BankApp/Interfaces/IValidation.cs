namespace Utilities
{
    public interface IValidation
    {
        bool AcctNumValidator(string check);
        bool AmountValidator(string check);
        bool EmailValidator(string check);
        bool NameValidator(string check);
        bool NumberCheck(string number);
        bool PasswordValidator(string check);
    }
}