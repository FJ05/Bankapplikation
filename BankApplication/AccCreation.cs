using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Xml.Linq;
using BankApplication;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BankApplication
{
    class AccCreation
    {
        public static void AccCreate()
        {
            Console.WriteLine("Enter your first name");
            string? firstName = Console.ReadLine();
            // fail check for first name
            List<char> firstname = new List<char>();
            List<char> newFirstname = new List<char>();
            firstname.AddRange(firstName);
            int indexFirstName = 0;
            foreach(char letter in firstname)
            {
                if (indexFirstName == 0)
                {
                    newFirstname.Add(char.ToUpper(letter));
                }
                else
                {
                    newFirstname.Add(char.ToLower(letter));
                }
                indexFirstName++;
            }
            firstName = new string(newFirstname.ToArray());

            Console.WriteLine("Enter your last name");
            string? lastName = Console.ReadLine();
            // fail check for last name
            List<char> lastname = new List<char>();
            List<char> newLastname = new List<char>();
            lastname.AddRange(lastName);
            int indexLastName = 0;
            foreach (char letter in lastname)
            {
                if (indexLastName == 0)
                {
                    newLastname.Add(char.ToUpper(letter));
                }
                else
                {
                    newLastname.Add(char.ToLower(letter));
                }
                indexLastName++;
            }
            lastName = new string(newLastname.ToArray());

            bool ValidSSN = false;
            string? sSN;
            do
            {
                Console.WriteLine("Enter your social security number; ex: YYMMDDXXXX");
                sSN = Console.ReadLine();
                List<char> SSN = new List<char>();
                int lenght = 0;
                foreach(char number in SSN)
                {
                    switch (number)
                    {
                        case '0':
                        case '1':
                        case '2':
                        case '3':
                        case '4':
                        case '5':
                        case '6':
                        case '7':
                        case '8':
                        case '9':
                            lenght++;
                            ValidSSN = true;
                            // stuff i am stuff
                            break;
                        default:
                            Console.WriteLine("Syntax error: input must contain only numbers");
                            ValidSSN = false;
                            break;

                    }
                }
                if (lenght > 10)
                {
                    Console.WriteLine("Syntax error: SSN must be written in this format: YYMMDDXXXX");
                    ValidSSN = false;
                }
                else if (lenght < 10)
                {
                    Console.WriteLine("Syntax error SSN must be written in this format: YYMMDDXXXX");
                    ValidSSN = false;
                }
                else if (lenght == 11)
                {
                    Console.WriteLine("Syntax error SSN must be written in this format: YYMMDDXXXX");
                    ValidSSN = false;
                }

            }
            while(ValidSSN);

            Console.WriteLine("enter a password");
            string? password = Console.ReadLine();
            Customer cust = new Customer(firstName, lastName, sSN, password);
            // makes the defult account
            Account account = new(0);
            cust.bankAccount.Add(account);

            // saves the data
            string fileName = "BankDataBase.json";
            string path = Path.Combine(Environment.CurrentDirectory, @"Properties\", fileName);
            List<Customer> custs = new();
            custs.Add(cust);

            // takes existing data and rewrites it
            // goal is to collect all data from BankData and then create a new list with that data and the newly added data, clear the entire file and rewrite it.
            string json = File.ReadAllText(path);
            var accList = JsonConvert.DeserializeObject<List<Customer>>(json);

            foreach(var acc in accList)
            {
                custs.Add(acc);
            }

            File.WriteAllText(path, string.Empty);
            string output = JsonConvert.SerializeObject(custs.ToArray(), Formatting.Indented);
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(output);
            }
            // https://www.newtonsoft.com/json/help/html/SerializingJSON.htm document for newtonsoft
        }
    }
}
