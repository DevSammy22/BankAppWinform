using Models;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Storage
{
    public class CustomerStorage
    {
        public static List<Customer> customers = new List<Customer>();
        static string customerFilePath = "CustomerStorage.csv";

        public static async Task SaveCustomerToFile(Customer customer)
        {
            using StreamWriter writer = new StreamWriter(customerFilePath, true);
            string customerDetails = $"{customer.Id},{customer.FirstName},{customer.LastName},{customer.Email},{customer.Password},{customer.DateCreated}";
            await writer.WriteLineAsync(customerDetails);
        }

        public static void GetCustomerFromFile()
        {
            string line;
            if (File.Exists(customerFilePath))
            {
                using StreamReader reader = new StreamReader(customerFilePath);
                while ((line = reader.ReadLine()) != null)
                {
                    string[] customerDetails = line.Split(',');
                    string id = customerDetails[0];
                    string firstName = customerDetails[1];
                    string lastName = customerDetails[2];
                    string email = customerDetails[3];
                    string password = customerDetails[4];
                    string dateCreated = customerDetails[5];

                    var customerFromFile = new Customer(id, firstName, lastName, email, password, dateCreated);
                    customers.Add(customerFromFile);
                }
            }
        }

    }
}
