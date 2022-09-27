using BankAccount;

Account account = new Account(100, "Filip Jansson", "20051116xxxx");

Console.WriteLine($"account number {account.AcNum} Customer ID {account.CustomerID} Name {account.Name} SSN {account.SSN}");