using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school
{
    abstract class Employee
    {
        protected string Name { get; set; }
        protected string SSN { get; set; }

        public Employee(string name, string sSN)
        {
            Name = name;
            SSN = sSN;
        }

        public abstract string getInfo(); // tvingar subklasser att skapa metoden getInfo()
    }

    class Teacher : Employee
    {
        private string Subjects { get; set; }

        // base anropar superklassens konstruktor!
        public Teacher(string name, string sSN, string subjects) : base(name, sSN)
        {
            Subjects = subjects;
        }

        public override string getInfo()
        {
            return $"name: {Name} SSN: {SSN} subjects: {Subjects}";
        }
    }

    class Boss : Employee
    {
        public Boss(string name, string sSN) : base(name, sSN)
        {

        }

        public override string getInfo()
        {
            return $"name: {Name} SSN: {SSN}";
        }
    }
}
