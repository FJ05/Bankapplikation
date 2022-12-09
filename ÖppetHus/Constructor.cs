using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖppetHus
{
    class Constructor
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Constructor (string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
