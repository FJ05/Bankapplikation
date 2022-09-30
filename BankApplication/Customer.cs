using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankApplication;
namespace BankApplication
{
    class Customer
    {
        public List<Account> bankAccount;
        private int customerID;
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? SSN { get; set; }
        public string? Password { get; set; }
        public int CustomerID
        {
            get { return CustomerID; }

            set
            {
                Random RNG = new Random();

                // Generates a Account number
                value = RNG.Next(100000, 999999);
                CustomerID = value;

                // Check if the Account number does not already exist
            }
        }
        public Customer(string? firstName, string? lastName, string? sSN, string? password)
        {
            FirstName = firstName;
            LastName = lastName;
            SSN = sSN;
            CustomerID = customerID;        
            bankAccount = new List<Account>();
            Password = password;
        }
    }
}
