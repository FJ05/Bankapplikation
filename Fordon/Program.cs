using Fordon;
List<Vehicle> Vehicles = new List<Vehicle>();
while (true)
{
    Console.WriteLine("press 1 for Car\npress 2 for Electric Bike\npress 3 for MC");
    string? choise = Console.ReadLine();

    if (choise == "1")
    {
        Console.WriteLine("hk:");
        int hk = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("brand:");
        string brand = Console.ReadLine();

        string color = Console.ReadLine();

        Vehicles.Add(new Car(hk, brand, color));
    }
    else if (choise == "2")
    {
        Console.WriteLine("hk:");
        int hk = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("brand:");
        string brand = Console.ReadLine();

        string color = Console.ReadLine();

        Vehicles.Add(new ElectricBike(hk, brand, color));
    }
    else if (choise == "3")
    {
        Console.WriteLine("hk:");
        int hk = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("brand:");
        string brand = Console.ReadLine();

        string color = Console.ReadLine();

        Vehicles.Add(new MC(hk, brand, color));
    }
}