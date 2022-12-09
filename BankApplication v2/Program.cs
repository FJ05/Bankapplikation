using BankApplication_v2;

SavingsAccount savings = new(0, 1, 80);
BankAccount bank = new(1000, 2);
BankAccount bank2 = new(59999999, 4);

List<Tuple<string, int>> stock = new();
stock.Add(new Tuple<string, int>("GME", 100));
stock.Add(new Tuple<string, int>("BANOF", 10000000));
StockAccount stocks = new(1000, 3, stock);

List<BankAccount> bnk = new();
bnk.Add(bank);
bnk.Add(bank2);
List<SavingsAccount> svn = new();
svn.Add(savings);
List<StockAccount> stk = new();
stk.Add(stocks);

Account acc = new("Filip", "Jansson", "0511160000", "Password", stk, svn, bnk);

Console.WriteLine(acc.getInfo());

foreach(var BankAccount in acc.BankAccounts)
{
    Console.WriteLine(BankAccount.getInfo());
    
}
foreach (var savingsAccount in acc.SavingsAccounts)
{
    Console.WriteLine(savingsAccount.getInfo());
}
foreach (var stockAccount in acc.StockAccounts)
{
    Console.WriteLine(stockAccount.getInfo());
}