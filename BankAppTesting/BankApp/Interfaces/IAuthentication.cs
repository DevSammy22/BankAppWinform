using Models;

namespace BusinessLogic
{
    public interface IAuthentication
    {
        bool Login(string email, string password);
        bool Logout();
        Customer Registration(string firstName, string lastName, string email, string password, string accountType);
    }
}