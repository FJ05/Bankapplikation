using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    class Loader
    {
        public static void Load()
        {
            Console.Clear();
            string fileName = "BankDataBase.json";
            string path = Path.Combine(Environment.CurrentDirectory, @"Properties\", fileName);

            // Lists all saved accounts
            string json = File.ReadAllText(path);
            var accList = JsonConvert.DeserializeObject<List<Customer>>(json);
            foreach(var acc in accList)
            {
                Graphics.Bar();
                Console.WriteLine($"\nName: {acc.FirstName}\n" +
                    $"Last name: {acc.LastName}\n" +
                    $"CustomerID: {acc.CustomerID}\n" +
                    $"Password: {acc.Password}\n");
                foreach(var bk in acc.bankAccount)
                {
                    Console.WriteLine($"Bank Account Number: {bk.AcNum}\n" +
                    $"Bank Account Balance: {bk.AcBalance}\n");
                }
            }
            Graphics.Bar();
            Console.WriteLine("Press enter to return to the main menu...");
            Console.ReadLine();
            MainMenu.Menu();
        }
    }
}
