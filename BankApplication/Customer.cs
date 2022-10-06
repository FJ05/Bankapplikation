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
    class Customer
    {
        Random RNG = new Random();
        public List<Account> bankAccount;
        private int customerID;
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? SSN { get; set; }
        public string? Password { get; set; }
        public int CustomerID
        {
            get { return customerID; }

            set
            {
                Console.Clear();
                string fileName = "BankDataBase.json";
                string path = Path.Combine(Environment.CurrentDirectory, @"Properties\", fileName);
                List<Customer> custs = new();
                string json = File.ReadAllText(path);
                var accList = JsonConvert.DeserializeObject<List<Customer>>(json);

                bool ssnIsUniqe = true;
                do
                {
                    ssnIsUniqe = true;
                    value = RNG.Next(100000, 999999);
                    customerID = value;

                    foreach(var acc in accList)
                    {
                        if (acc.customerID == value)
                        {
                            ssnIsUniqe = false;
                        }
                    }
                } while (!ssnIsUniqe);
                // Generates a random customerID number for the user
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
