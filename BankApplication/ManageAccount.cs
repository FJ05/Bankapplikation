using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BankApplication
{
    class ManageAccount
    {
        public static void Manage()
        {
            Console.Clear();
            string fileName = "BankDataBase.json";
            string path = Path.Combine(Environment.CurrentDirectory, @"Properties\", fileName);
            List<Customer> custs = new();
            string json = File.ReadAllText(path);
            var accList = JsonConvert.DeserializeObject<List<Customer>>(json);

            Console.WriteLine("Enter the SSN of the person you want to edit:");
            Graphics.Bar();
            string? ssn = Console.ReadLine();

            Console.WriteLine("Enter their Password:");
            Graphics.Bar();
            string? password = Console.ReadLine();
            foreach (var acc in accList)
            {
                if(acc.SSN == ssn)
                {
                    if(acc.Password == password) 
                    {
                        Console.WriteLine("You're logged into" + $" {acc.FirstName} {acc.LastName}");
                        Console.WriteLine("bank accounts tied to this account:");
                        Graphics.Bar();
                        foreach (var bk in acc.bankAccount)
                        {
                            Console.WriteLine($"\nBank account number: {bk.AcNum}\n" +
                                $"Bank account balance: {bk.AcBalance}\n");
                            Graphics.Bar();
                        }

                        Console.WriteLine("Type the Bank account number that you want to change the balance of:\nWrite \"2\" to add a new bank account");
                        Graphics.Bar();
                        string? BankAccNum = Console.ReadLine();

                        if(BankAccNum == "2")
                        {
                            Account account = new Account(0);
                            acc.bankAccount.Add(account);

                            List<Customer> saveCusts = new();
                            saveCusts.Add(acc);
                            // prevents duplicating in json folder
                            foreach (var accs in accList)
                            {
                                if (accs.SSN != ssn)
                                {
                                    if (accs.Password != password)
                                    {
                                        saveCusts.Add(accs);
                                    }
                                }
                            }
                            File.WriteAllText(path, string.Empty); // delets account data and rewrites
                            string output = JsonConvert.SerializeObject(saveCusts.ToArray(), Formatting.Indented);
                            using (StreamWriter sw = File.AppendText(path))
                            {
                                sw.WriteLine(output);
                            }
                            Graphics.Bar();
                            Console.WriteLine("Press enter to return to the main menu...");
                            Console.ReadLine();
                            MainMenu.Menu();
                        }
                        foreach(var bk in acc.bankAccount)
                        {
                            if(bk.AcNum.ToString() == BankAccNum)
                            {
                                while (true)
                                {
                                    Graphics.Bar();
                                    Console.WriteLine("Write \"1\" to deposit\nWrite \"2\" to withdrawl");
                                    Graphics.Bar();
                                    string choise = Console.ReadLine();
                                    Console.Clear();
                                    if (choise.ToLower() == "1")
                                    {
                                        Console.WriteLine("Enter the amout that you want to deposit");
                                        Graphics.Bar();
                                        string input = Console.ReadLine();
                                        try
                                        {
                                            int result = Int32.Parse(input);

                                            bk.AcBalance += result;

                                            // saves changes
                                            List<Customer> saveCusts = new();
                                            saveCusts.Add(acc);

                                            // prevents duplicating in json folder
                                            foreach(var account in accList)
                                            {
                                                if (account.SSN != ssn)
                                                {
                                                    if (account.Password != password)
                                                    {
                                                        saveCusts.Add(account);
                                                    }
                                                }
                                            }
                                            File.WriteAllText(path, string.Empty); // delets account data and rewrites
                                            string output = JsonConvert.SerializeObject(saveCusts.ToArray(), Formatting.Indented);
                                            using (StreamWriter sw = File.AppendText(path))
                                            {
                                                sw.WriteLine(output);
                                            }
                                            Graphics.Bar();
                                            Console.WriteLine("Press enter to return to the main menu...");
                                            Console.ReadLine();
                                            MainMenu.Menu();
                                        }
                                        catch (FormatException)
                                        {
                                            Graphics.Bar();
                                            Console.WriteLine($"Unable to parse '{input}'");
                                            Console.WriteLine("Press enter to return to the main menu...");
                                            Console.ReadLine();
                                            MainMenu.Menu();
                                        }
                                    }
                                    else if (choise.ToLower() == "2")
                                    {
                                        Graphics.Bar();
                                        Console.WriteLine("Enter the amout that you want to withdrawl");
                                        Graphics.Bar();
                                        string input = Console.ReadLine();
                                        try
                                        {
                                            int result = Int32.Parse(input);
                                            if (bk.AcBalance - result >= 0)
                                            {
                                                bk.AcBalance -= result;

                                                // saves changes
                                                List<Customer> saveCusts = new();
                                                saveCusts.Add(acc);

                                                // prevents duplicating in json folder
                                                foreach (var account in accList)
                                                {
                                                    if (account.SSN != ssn)
                                                    {
                                                        if (account.Password != password)
                                                        {
                                                            saveCusts.Add(account);
                                                        }
                                                    }
                                                }
                                                File.WriteAllText(path, string.Empty); // delets account data and rewrites
                                                string output = JsonConvert.SerializeObject(saveCusts.ToArray(), Formatting.Indented);
                                                using (StreamWriter sw = File.AppendText(path))
                                                {
                                                    sw.WriteLine(output);
                                                }
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine($"You cannot withdrawl more than you have in your account!\npress enter to continue...");

                                                Console.ReadLine();

                                            }
                                            Graphics.Bar();
                                            Console.WriteLine("Press enter to return to the main menu...");
                                            Console.ReadLine();
                                            MainMenu.Menu();
                                        }
                                        catch (FormatException)
                                        {
                                            Graphics.Bar();
                                            Console.WriteLine($"Unable to parse '{input}'");
                                            Console.WriteLine("Press enter to return to the main menu...");
                                            Console.ReadLine();
                                            MainMenu.Menu();
                                        }
                                    }
                                    Console.Clear();
                                }
                                Console.Clear();

                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("You've entered the wrong password");
                    }
                }
                else
                {
                    Console.WriteLine("SSN was not found in our database");
                }
            }
        }
    }
}
