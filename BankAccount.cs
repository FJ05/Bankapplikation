namespace BankAccount
{
    class Account   //Class
    {
        public int AcBalance { get; set; }
        public int AcNum { get; set; }
        public string Name { get; set; }
        public int SSN { get; set; }
        public int CustomerID { get; set;}
        public Account(int acBalance, int acNum, string name, int sSN, int customerID)    // Constructor
        {
            AcBalance = acBalance;
            AcNum = acNum;
            Name = name;
            SSN = sSN;
            CustomerID = customerID;
        }


    }
}