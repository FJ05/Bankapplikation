using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Resebolag
{
    class AddHotel
    {
        public void addHotel()
        {
            Console.Clear();
            // Add Hotel
            Console.WriteLine("Hotel Name:");
            string? companyName = Console.ReadLine();

            Console.WriteLine("City:");
            string? city = Console.ReadLine();

            Console.WriteLine("Rating (ex \"4.5\") max 5.0, min 0.0:"); // fix max and min value
            double rating;
            while (true)
            {
            
                bool success = double.TryParse(Console.ReadLine(), out rating);
                if (success)
                    break;
                else
                    Console.WriteLine("Syntax error. try again");
            }

            Console.WriteLine("Total of rooms:");
            int totalRooms;
            while (true)
            {

                bool success = int.TryParse(Console.ReadLine(), out totalRooms);
                if (success)
                    break;
                else
                    Console.WriteLine("Syntax error. try again");
            }

            List<Room> rooms = new List<Room>();
            Console.WriteLine("Types of rooms. At least one in nessasary");
            while (true)
            {
                Console.WriteLine("room type name:");
                string? roomType = Console.ReadLine();

                Console.WriteLine("Total rooms of this type:");
                int totalRoomsOfType;
                while (true)
                {

                    bool success = int.TryParse(Console.ReadLine(), out totalRoomsOfType);
                    if (success)
                        break;
                    else
                        Console.WriteLine("Syntax error. try again");
                }

                Console.WriteLine("Price per night: (USD$)");
                int pricePerNight;
                while (true)
                {

                    bool success = int.TryParse(Console.ReadLine(), out pricePerNight);
                    if (success)
                        break;
                    else
                        Console.WriteLine("Syntax error. try again");
                }

                bool roomService = false;
                bool choiseHasBeenMade = false;
                while (!choiseHasBeenMade)
                {
                    Console.WriteLine("Includes room service [Y/N]");
                    ConsoleKeyInfo readKey = Console.ReadKey();

                    switch (readKey.Key)
                    {
                        case ConsoleKey.Y:
                            roomService = true;
                            choiseHasBeenMade = true;
                            break;
                        case ConsoleKey.N:
                            roomService = false;
                            choiseHasBeenMade = true;
                            break;
                    }
                }

                Room room = new(roomType, totalRoomsOfType, pricePerNight, roomService);
                rooms.Add(room);

                Console.WriteLine("Add one more room type? [Y]");


                bool makeAnother;
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.Y:
                        makeAnother = true;
                        break;
                    default:
                        makeAnother = false;
                        break;
                }
                if (!makeAnother)
                {
                    break;
                }
            }
            Hotel _Hotel = new(rooms, companyName, city, rating, totalRooms);
            // Adds hotel to json
            string path = Path.Combine(Environment.CurrentDirectory, @"Properties\", "Database.json");

            string json = File.ReadAllText(path);
            Console.WriteLine($"{json}");
            List<Company> companyList = new List<Company>();
            
            companyList.Add(_Hotel);

            
            List<Company> JsonList = JsonConvert.DeserializeObject<List<Company>>(json);

            if (JsonList != null)
            {
                foreach(Company obj in JsonList)
                {
                    companyList.Add(obj);
                }
            }
            
            File.WriteAllText(path, string.Empty);

            // Ett objekt som håller listan av Companies
            var settings = new JsonSerializerSettings();
            settings.TypeNameHandling = TypeNameHandling.Objects;

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(JsonConvert.SerializeObject(companyList, Formatting.Indented, settings));
            }

            Console.WriteLine("Company has been saved! Press enter to close the aplication");
            Environment.Exit(0);
        }

    }
}
