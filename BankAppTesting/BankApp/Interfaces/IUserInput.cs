using Models;

namespace UserInterface
{
    public interface IUserInput
    {
        void Begin();
        void CreateAccount(Customer customer);
    }
}