namespace BankAccount
{
    class BankAccount   //Class
    {
        public int AcBalance { get; set; }
        public int AcNum { get; set; }

        public BankAccount(int acBalance, int acNum)    // Konstruktor
        {
            AcBalance = acBalance;
            AcNum = acNum;
        }
    }
}