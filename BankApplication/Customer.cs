using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using BankApplication;
using Newtonsoft.Json;

namespace BankApplication
{
    /// <summary>
    ///     Propertirs for customer and includes informative information about the customer.
    ///     The customer class also makes it possible to store multible bank accounts in this object.
    /// </summary>
    class Customer
    {
        Random RNG = new Random();
        /// <value>
        ///     List to host all the users bank accounts in.
        /// </value>
        public List<Account> bankAccount;
        /// <value>
        ///     The customerID lets us keep track of the of the users by their randomly generated number also called seed
        /// </value>
        private int customerID;
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? SSN { get; set; }
        public string? Password { get; set; }

        /// <summary>
        ///     Randomy generetes the CustomerID
        /// </summary>
        public int CustomerID
        {
            get { return customerID; }

            set
            {
                value = RNG.Next(100000, 999999);
                customerID = value;
                // Check if the ID number already exists
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