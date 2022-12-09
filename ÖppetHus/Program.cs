using ÖppetHus;

Console.WriteLine("Enter your name:");
string? name = Console.ReadLine();

Console.WriteLine("Enter your age:");
int age = Convert.ToInt32(Console.ReadLine());

Constructor cons = new Constructor(name, age);

Console.WriteLine(cons.Name + " är " + cons.Age + "år");