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
        private int customerID;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SSN { get; set; }
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
        public List<Account> bankAccount = new List<Account>();
        public Customer(string firstName, string lastName, string sSN)
        {
            FirstName = firstName;
            LastName = lastName;
            SSN = sSN;
            CustomerID = customerID;        }
    }
}
