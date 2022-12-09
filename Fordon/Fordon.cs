using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Fordon
{
    abstract class Vehicle
    {
        protected int Hk { get; set; }
        protected string Brand { get; set; }
        protected string Color { get; set; }

        public Vehicle(int hk, string brand, string color)
        {
            Hk = hk;
            Brand = brand;
            Color = color;
        }

        public abstract string getInfo();
    }

    class Car : Vehicle
    {
        public string RegNr { get; set; }
        public int Seats { get; set; }

        public Car(int hk, string brand, string color, string regNr, int seats) : base(hk, brand, color)
        {
            RegNr = regNr;
            Seats = seats;
        }

        public override string getInfo()
        {
            return $"hk {Hk}, brand: {Brand}, Color {Color}, registation number: {RegNr}, seats: {Seats}";        
        }
    }

    class ElectricBike : Vehicle
    {
        public bool Foldable { get; set; }
        public ElectricBike(int hk, string brand, string color, bool foldable) : base(hk, brand, color)
        {
            Foldable = foldable;
        }
        public override string getInfo()
        {
            string foldInfo;
            if (Foldable)
            {
                foldInfo = "is foldable";
            }
            else
            {
                foldInfo = "is not foldable";
            }

            return $"hk {Hk}, brand: {Brand}, Color {Color}, foldable: {foldInfo}";
        }
    }

    class MC : Vehicle
    {
        public string RegNr { get; set; }
        public MC(int hk, string brand, string color, string regNr) : base(hk, brand, color)
        {
            RegNr = regNr;
        }
        public override string getInfo()
        {
            return $"hk {Hk}, brand: {Brand}, Color {Color}, registration number {RegNr}";
        }
    }
}
