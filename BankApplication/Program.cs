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
            // Bugs in program
            // 1. if a account with the same ssn and password is created the old mirror account will be deleted (it's not a bug, it's a feture ;) )
            // 2. everytime something updates in the database every ID will be randomly generated again (not a huge deal. quick fix but me lazy)
            // 3. 
        }
    }
}