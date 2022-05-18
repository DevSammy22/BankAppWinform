using Models;
using Storage;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        public void AddCustomer(Customer customer)
        {
            CustomerStorage.customers.Add(customer);
        }

    }
}
