using System;
using System.Collections.Generic;

namespace Models
{
    public class Customer
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password  { get; set; }
        public string DateCreated { get; set; }
        //public Address Address { get; set; }
        public ICollection<Account> Accounts { get; set; }
       
        public Customer(string id, string firstName, string lastName, string email, string password, string dateCreated)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            DateCreated = dateCreated;
        }

    }
}
