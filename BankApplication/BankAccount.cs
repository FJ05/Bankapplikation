namespace BankApplication
{
    // Is used to create a account
    class Account
    {
        private int acNum;
        public int AcBalance { get; set; }
        public int AcNum
        { 
            get { return acNum;} 

            set
            {
                Random RNG = new Random();

                // Generates a random Account number
                value = RNG.Next(100000, 999999);
                acNum = value;

                // Check if the Account number already exists
            }
        }
        public Account(int acBalance)
        {
            AcBalance = acBalance;
            AcNum = acNum;
        }
    }
}