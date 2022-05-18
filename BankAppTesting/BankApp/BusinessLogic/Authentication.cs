using Models;
using Storage;
using System;
using System.Linq;

namespace BusinessLogic
{
    public class Authentication : IAuthentication
    {

        public static Customer LogInCustomer { get; set; }

        public Customer Registration(string firstName, string lastName, string email, string password, string accountType)
        {
            string id = Guid.NewGuid().ToString();
            string dateCreated = DateTime.Now.ToString();
            Customer customer = new Customer(id, firstName, lastName, email, password, dateCreated);
            CustomerStorage.customers.Add(customer);
            CustomerStorage.SaveCustomerToFile(customer).GetAwaiter();
            return customer;
        }

        public bool Login(string email, string password)
        {
            Customer customer = CustomerStorage.customers.FirstOrDefault(x => x.Email == email);
            if (customer != null)
            {
                if (customer.Password == password)
                {
                    LogInCustomer = customer;
                    return true;
                }
                return false;
            }

            return false;
        }

        public bool Logout()
        {
            LogInCustomer = null;
            return true;
        }

    }
}
