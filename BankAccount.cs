namespace BankAccount
{
    class Account   //Class
    {
        public int AcBalance { get; set; }

        public int AcNum
        { 
            get;

            set
            {
                Random RNG = new Random();

                // Generates a Account number
                value = RNG.Next(100000, 999999);

                // Check if the Account number does not already exist
            }
        }
        public Account(int acBalance, int acNum)    // Konstruktor
        {
            AcBalance = acBalance;
            AcNum = acNum;
        }
    }
}