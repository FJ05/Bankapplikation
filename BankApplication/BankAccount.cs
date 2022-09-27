namespace BankAccount
{
    class Account   //Class
    {
        private int customerID;
        private int acNum;
        public int AcBalance { get; set; }
        public string Name { get; set; }
        public string SSN { get; set; }
        public int CustomerID
        { 
            get { return customerID; }

            set
            {
                Random RNG = new Random();

                // Generates a Account number
                value = RNG.Next(100000, 999999);
                customerID = value;

                // Check if the Account number does not already exist
            }
        }
        public int AcNum
        { 
            get { return acNum;} 

            set
            {
                Random RNG = new Random();

                // Generates a Account number
                value = RNG.Next(100000, 999999);
                acNum = value;

                // Check if the Account number does not already exist
            }
        }
        public Account(int acBalance, string name, string sSN)
        {
            AcBalance = acBalance;
            AcNum = acNum;
            Name = name;
            SSN = sSN;
            CustomerID = customerID;
        }
    }
}