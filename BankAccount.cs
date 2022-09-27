namespace BankAccount
{
    class Account   //Class
    {
        public int AcBalance { get; set; }
        public int AcNum { get; set; }

        public Account(int acBalance, int acNum)    // Konstruktor
        {
            AcBalance = acBalance;
            AcNum = acNum;
        }
    }
}