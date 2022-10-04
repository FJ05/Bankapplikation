using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankApplication;
namespace BankApplication
{
    class MainMenu
    {
        public static void Menu()
        {
            Console.Clear();
            Graphics.Bar();
            Console.WriteLine("1. Create a new account\n" +
                "2. Log into an existing account\n" +
                "3. Browse all accounts\n" +
                "4. Search in database");
            Graphics.Bar();

            int choise = 0;
            bool userRightChoise = false;
            while (!userRightChoise)
            {
                bool success = false;
                do
                {
                    string? menuChoise = Console.ReadLine();
                    success = int.TryParse(menuChoise, out int number);
                    choise = number;
                    if (number == 4)
                        userRightChoise = true;
                    if (number == 3)
                        userRightChoise = true;
                    if (number == 2)
                        userRightChoise = true;
                    if (number == 1)
                        userRightChoise = true;
                }
                while (success == false);
            }
            Console.Clear();
            if (choise == 1)
            {
                // Creates a new Account
                AccCreation.AccCreate();
            }
            else if (choise == 2)
            {
                // Manage account
                ManageAccount.Manage();
            }
            else if (choise == 3)
            {
                // Browse all accounts
                Loader.Load();
            }
            else if (choise == 4)
            {
                // search all accounts
                Search.search();
            }
        }
    }
}
