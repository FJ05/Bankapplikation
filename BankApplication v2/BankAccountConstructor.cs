using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication_v2
{
    abstract class SubAccount
    {
        protected int Balance { get; set; }
        protected int AccountNumber { get; set; }

        public SubAccount(int balance, int accountNumber)
        {
            Balance = balance;
            AccountNumber = accountNumber;
        }
        public abstract string getInfo();
    }
    class BankAccount : SubAccount
    {
        
        public BankAccount(int balance, int accountNumber) : base(balance, accountNumber)
        {

        }
        public override string getInfo()
        {
            return $"balance: {Balance} Account number: {AccountNumber}";
        }
    }
    class SavingsAccount : SubAccount
    {
        private byte SavingsInterest { get; set; }

        public SavingsAccount(int balance, int accountNumber, byte savingsInterest) : base(balance, accountNumber)
        {
            SavingsInterest = savingsInterest;
        }
        public override string getInfo()
        {
            return $"balance: {Balance} Account number: {AccountNumber} Saving Intrest: {SavingsInterest}";
        }
    }
    class StockAccount : SubAccount
    {
        private List<Tuple<string, int>> Stocks { get; set; }
        public StockAccount(int balance, int accountNumber, List<Tuple<string, int>> stocks) : base(balance, accountNumber)
        {
            Stocks = stocks;
        }
        public override string getInfo()
        {
            string stock = string.Join(",", Stocks.Select(t => string.Format("[{0}, {1}]", t.Item1, t.Item2))); // fixes formating
            return $"balance: {Balance} Account number: {AccountNumber} Stocks:{stock} share/s";
        }
    }
}
