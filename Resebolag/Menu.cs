using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Resebolag
{
    abstract class Menu
    {
        public abstract void moveUp();
        public abstract void moveDown();
        protected static int Choise { get; set; }
        public Menu(int choise)
        {
            Choise = choise;
        }
        public abstract void updateGraphics();
        public abstract int getState();
        
    }
    class MainMenu : Menu
    {
        public override void moveUp()
        {
            Choise--;
        }
        public override void moveDown()
        {
            Choise++;
        }
        public MainMenu(int choise) : base(choise)
        {

        }

        public override void updateGraphics()
        {
            switch (Choise)
            {
                case 0:
                    Console.Clear();
                    Console.WriteLine("Use the arrow keys to navigate. Press Enter to select\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Add Company");
                    Console.ResetColor();
                    Console.WriteLine("Browse all companies");
                    Console.WriteLine("Search companies by location");
                    break;
                case 1:
                    Console.Clear();
                    Console.WriteLine("Use the arrow keys to navigate. Press Enter to select\n");
                    Console.WriteLine("Add Company");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Browse all companies");
                    Console.ResetColor();
                    Console.WriteLine("Search companies by location");
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Use the arrow keys to navigate. Press Enter to select\n");
                    Console.WriteLine("Add Company");
                    Console.WriteLine("Browse all companies");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Search companies by location");
                    Console.ResetColor();
                    break;
                case -1:
                    Choise = 0;
                    break;
                case 3:
                    Choise = 2;
                    break;
            }
        }

        public override int getState()
        {
            return Choise;
        }
    }

    class SelectCompType : Menu
    {
        public override void moveUp()
        {
            Choise--;
        }
        public override void moveDown()
        {
            Choise++;
        }
        public SelectCompType(int choise) : base(choise)
        {

        }

        public override void updateGraphics()
        {
            switch (Choise)
            {
                case 0:
                    Console.Clear();
                    Console.WriteLine("Use the arrow keys to navigate. Press Enter to select\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Add a Hotel");
                    Console.ResetColor();
                    Console.WriteLine("Add a Hostel");
                    Console.WriteLine("Add a B&B");
                    break;
                case 1:
                    Console.Clear();
                    Console.WriteLine("Use the arrow keys to navigate. Press Enter to select\n");
                    Console.WriteLine("Add a Hotel");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Add a Hostel");
                    Console.ResetColor();
                    Console.WriteLine("Add a B&B");
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Use the arrow keys to navigate. Press Enter to select\n");
                    Console.WriteLine("Add a Hotel");
                    Console.WriteLine("Add a Hostel");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Add a B&B");
                    Console.ResetColor();
                    break;
                case -1:
                    Choise = 0;
                    break;
                case 3:
                    Choise = 2;
                    break;
            }
        }

        public override int getState()
        {
            return Choise;
        }
    }      
}
