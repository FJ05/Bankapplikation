using Resebolag;
using System.ComponentModel;
using System.Security.Cryptography;
using System.Transactions;

MainMenu menu = new(0);
menu.updateGraphics();

bool choosing = true;
while (choosing)
{
    int Choice = menu.getState();
    switch (Console.ReadKey().Key)
    {
        case ConsoleKey.UpArrow:
            menu.moveUp();
            break;
        case ConsoleKey.DownArrow:
            menu.moveDown();
            break;
        case ConsoleKey.Enter:
            choosing = false;
            break;
    }
    menu.updateGraphics();
}
if(menu.getState() == 0)
{
    // Add a company
    SelectCompType selectCompType = new(0);

    bool choosingType = true;
    while (choosingType)
    {
        selectCompType.updateGraphics();
        int TypeChoice = selectCompType.getState();
        switch (Console.ReadKey().Key)
        {
            case ConsoleKey.UpArrow:
                selectCompType.moveUp();
                break;
            case ConsoleKey.DownArrow:
                selectCompType.moveDown();
                break;
            case ConsoleKey.Enter:
                choosingType = false;
                break;
        }
        selectCompType.updateGraphics();
    }

    if(selectCompType.getState() == 0)
    {
        AddHotel _Addhotel = new();
        _Addhotel.addHotel();
    }
    else if(selectCompType.getState() == 1)
    {
        // Add Hostel
    }
    else if(selectCompType.getState() == 2)
    {
        // Add B&B
    }
}
else if (menu.getState() == 1)
{
    // Browse all companies
    Console.WriteLine("test2");
}
else if (menu.getState() == 2)
{
    // Search for company
    Console.WriteLine("test3");
}