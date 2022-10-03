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
            string fileName = "BankDataBase.json";
            string path = Path.Combine(Environment.CurrentDirectory, @"Properties\", fileName);

            // will list all accounts
            string jsonSave = File.ReadAllText(path);
            Customer cust = JsonConvert.DeserializeObject<Customer>(jsonSave);
        }
    }
}
