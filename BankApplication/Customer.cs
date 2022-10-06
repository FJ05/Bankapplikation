﻿using System;
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
