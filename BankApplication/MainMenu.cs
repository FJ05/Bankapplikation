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
        public MainMenu()
        {
            Console.WriteLine("1. Create a new account\n" +
                "2. Log into an existing account\n" +
                "3. Browse all accounts");
            int choise = 0;
            bool userRightChoise = false;
            while (userRightChoise)
            {
                bool success = false;
                do
                {
                    string? menuChoise = Console.ReadLine();
                    success = int.TryParse(menuChoise, out int number);
                    choise = number;
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
                // Create a new Account
                AccCreation.AccCreate();
            }
            else if (choise == 2)
            {
                // Login

            }
            else if (choise == 3)
            {
                // Browse all accounts
                Loader.Load();
            }
        }
    }
}
