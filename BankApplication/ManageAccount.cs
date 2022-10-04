using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

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
            string? ssn = Console.ReadLine();

            Console.WriteLine("Enter their Password:");
            string? password = Console.ReadLine();
            foreach (var acc in accList)
            {
                if(acc.SSN == ssn)
                {
                    if(acc.Password == password) 
                    {
                        Console.WriteLine("You're logged into" + $"{acc.FirstName} {acc.LastName}");
                        Console.WriteLine("bank accounts tied to this account:");
                        foreach(var bk in acc.bankAccount)
                        {
                            Console.WriteLine($"Bank account number: {bk.AcNum}\n" +
                                $"Bank account balance: {bk.AcBalance}");
                        }

                        Console.WriteLine("Type the Bank account number that you want to change the balance of:");
                        string? BankAccNum = Console.ReadLine();

                        foreach(var bk in acc.bankAccount)
                        {
                            if(bk.AcNum.ToString() == BankAccNum)
                            {
                                Console.WriteLine("Enter the new balance:");
                                string input = Console.ReadLine();
                                try
                                {
                                    int result = Int32.Parse(input);

                                    bk.AcBalance = result;

                                    // saves changes

                                    File.WriteAllText(path, string.Empty); // delets account data and rewrites
                                    string output = JsonConvert.SerializeObject(custs.ToArray(), Formatting.Indented);
                                    using (StreamWriter sw = File.AppendText(path))
                                    {
                                        sw.WriteLine(output);
                                    }
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine($"Unable to parse '{input}'");
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("You've entered the wrong password");
                    }
                }
            }
        }
    }
}
