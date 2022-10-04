using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    class Graphics
    {
        public static void Bar()        // Creates a "bar" of the color magenta and switches the main text colour back to darkcyan
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("_____________________________________________________________________________\n");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
        }

        public static void Logo()       // Outputs the "logo" in the console
        {
            Console.Write(@"     _                          ____                 _    
    | | ___   ___   _ __    _  | __ )   __ _  _ __  | | __
 _  | |/ __| / _ \ | '_ \  (_) |  _ \  / _` || '_ \ | |/ /
| |_| |\__ \| (_) || | | |  _  | |_) || (_| || | | ||   < 
 \___/ |___/ \___/ |_| |_| (_) |____/  \__,_||_| |_||_|\_\
");
        }
    }
}
