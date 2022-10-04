using BankApplication;
using System;
namespace BankApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Graphics changes goes in this box
            Graphics.Bar();
            Graphics.Logo();
            Graphics.Bar();
            //
            Console.WriteLine("Press enter to open the bank...");
            Console.ReadLine();
            Console.Clear();
            MainMenu.Menu();
        }
    }
}