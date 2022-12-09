using school;

List<Employee> employees = new();

while (true)
{
    Console.WriteLine("(L)ärare / (C)hef / (A)vsluta");
    string ans = Console.ReadLine();
    if (ans.ToLower() == "a")
        break;

    Console.WriteLine("Namn:");
    string name = Console.ReadLine();

    Console.WriteLine("Personnummer:");
    string ssn = Console.ReadLine();

    if (ans.ToLower() == "l")
    {
        Console.WriteLine("Ämnen:");
        string subjects = Console.ReadLine();

        employees.Add(new Teacher(name, ssn, subjects));
    }

    if (ans.ToLower() == "c")
    {
        Console.WriteLine("Ämnen:");

        employees.Add(new Boss(name, ssn));
    }
}
foreach (Employee employee in employees)
{
    Console.WriteLine(employee.getInfo());
}