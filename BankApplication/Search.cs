using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    class Search
    {
        public static void search()
        {
            string fileName = "BankDataBase.json";
            string path = Path.Combine(Environment.CurrentDirectory, @"Properties\", fileName);
            List<Customer> custs = new();
            string json = File.ReadAllText(path);
            var accList = JsonConvert.DeserializeObject<List<Customer>>(json);

            string? choise;
            while (true)
            {
                Console.WriteLine("1. To search for first name");
                Console.WriteLine("2. To search for last name");
                Console.WriteLine("3. To seach for ssn");

                choise = Console.ReadLine();
                if (choise == "1" || choise == "2" || choise == "3")
                {
                    break;
                }
                else
                    Console.Clear();
            }
            Console.Clear();
            if (choise == "1")
            {
                Console.WriteLine("Enter a first name");
                string? searchKeyWord = Console.ReadLine();
                int searchResults = 0;
                int tiedBankAccounts = 0;
                foreach(var cust in accList)
                {
                    if (cust.FirstName.ToLower() == searchKeyWord.ToLower())
                    {
                        searchResults++;
                        Console.WriteLine($"First name: {cust.FirstName}\n" +
                            $"Last name: {cust.LastName}\n" +
                            $"Ssn: {cust.SSN}\n");
                        foreach(var bankacc in cust.bankAccount)
                        {
                            tiedBankAccounts++;
                        }
                        Console.WriteLine($"{cust.FirstName} {cust.LastName} has {tiedBankAccounts} tied bank accounts.\n");
                    }
                    tiedBankAccounts = 0;
                }
                Console.WriteLine($"{searchResults}: results was found");
            }
            if (choise == "2")
            {
                Console.WriteLine("Enter a last name");
                string? searchKeyWord = Console.ReadLine();
                int searchResults = 0;
                int tiedBankAccounts = 0;
                foreach (var cust in accList)
                {
                    if (cust.LastName.ToLower() == searchKeyWord.ToLower())
                    {
                        searchResults++;
                        Console.WriteLine($"First name: {cust.FirstName}\n" +
                            $"Last name: {cust.LastName}\n" +
                            $"Sss: {cust.SSN}\n");
                        foreach (var bankacc in cust.bankAccount)
                        {
                            tiedBankAccounts++;
                        }
                        Console.WriteLine($"{cust.FirstName} {cust.LastName} has {tiedBankAccounts} tied bank accounts.\n");
                    }
                    tiedBankAccounts = 0;
                }
                Console.WriteLine($"{searchResults}: results was found");
            }
            if (choise == "3")
            {
                Console.WriteLine("Enter a ssn");
                string? searchKeyWord = Console.ReadLine();
                int searchResults = 0;
                int tiedBankAccounts = 0;
                foreach (var cust in accList)
                {
                    if (cust.SSN.ToLower() == searchKeyWord.ToLower())
                    {
                        searchResults++;
                        Console.WriteLine($"First name: {cust.FirstName}\n" +
                            $"Last name: {cust.LastName}\n" +
                            $"Ssn: {cust.SSN}\n");
                        foreach (var bankacc in cust.bankAccount)
                        {
                            tiedBankAccounts++;
                        }
                        Console.WriteLine($"{cust.FirstName} {cust.LastName} has {tiedBankAccounts} tied bank accounts.\n");
                    }
                    tiedBankAccounts = 0;
                }
                Console.WriteLine($"{searchResults}: results was found");
            }
            Console.WriteLine("Press enter to return to the main menu...");
            Console.ReadLine();
            MainMenu.Menu();
        }
    }
}
