using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using BankApplication_v2;

namespace BankApplication_v2
{
    class Account
    {
        public List<BankAccount> BankAccounts;
        public List<SavingsAccount> SavingsAccounts;
        public List<StockAccount> StockAccounts;
        private string Name { get; set; }
        private string SurName { get; set; }
        private string SSN { get; set; }
        private string Password { get; set; }
        
        public Account(string name, string surName, string sSN, string password, List<StockAccount> stockAccounts, List<SavingsAccount> savingsAccounts, List<BankAccount> bankAccounts)
        {
            Name = name;
            SurName = surName;
            SSN = sSN;
            Password = password;
            StockAccounts = stockAccounts;
            SavingsAccounts = savingsAccounts;
            BankAccounts = bankAccounts;
        }
        public string getInfo()
        {
            int bankAccAmount = BankAccounts.Count;
            int savingAccAmount = SavingsAccounts.Count;
            int stockAccAmount = StockAccounts.Count;
            return $"{Name} {SurName} {SSN}, {bankAccAmount} Bank accounts active, {savingAccAmount} Savings account active, {stockAccAmount} Stock accounts active";
        }
    }
}