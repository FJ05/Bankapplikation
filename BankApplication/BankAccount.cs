namespace BankApplication
{
    /// <summary>
    ///     Account object is a bankaccount that will be stored in the cutomer object.
    /// </summary>
    class Account
    {
        Random RNG = new Random();
        private int acNum;
        /// <value>
        ///     Stores the balance for the user
        /// </value>
        public int AcBalance { get; set; }
        /// <summary>
        ///     gives the account a acnum which is a random seed between 100000-999999
        /// </summary>
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