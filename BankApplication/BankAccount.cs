namespace BankApplication
{
    // Is used to create a account
    class Account
    {
        Random RNG = new Random();
        private int acNum;
        public int AcBalance { get; set; }
        public int AcNum
        { 
            get { return acNum;} 

            set
            {
                // Generates a random Account number
                value = RNG.Next(100000, 999999);
                acNum = value;
            }
        }
        public Account(int acBalance)
        {
            AcBalance = acBalance;
            AcNum = acNum;
        }
    }
}