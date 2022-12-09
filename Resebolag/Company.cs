using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Resebolag;

namespace Resebolag
{
    abstract class Company 
    {
        [JsonProperty("CompanyName")]
        protected string CompanyName;
        [JsonProperty("City")]
        protected string City;
        [JsonProperty("Rating")]
        protected double Rating;
        [JsonProperty("TotalRooms")]
        protected int TotalRooms;

        public Company(string companyName, string city, double rating, int totalRooms)
        {
            CompanyName = companyName;
            City = city;
            Rating = rating;
            TotalRooms = totalRooms;
        }

        public abstract string getInfo();
    }

    class Hotel : Company
    {
        [JsonProperty("Roomtypes")]
        List<Room> Roomtypes { get; set; }

        public Hotel(List<Room> roomtypes, string companyName, string city, double rating, int totalRooms) : base(companyName, city, rating, totalRooms)
        {
            Roomtypes = roomtypes;
        }

        public override string getInfo()
        {
            string roomtypes_ = string.Join(",", Roomtypes, " ");
            return $"City: {City} Name: {CompanyName} room types: {roomtypes_} number of rooms: {TotalRooms} rating ({Rating}/5)";
        }
    }

    class Hostel : Company
    {
        public Hostel(string companyName, string city, double rating, int totalRooms) : base(companyName, city, rating, totalRooms)
        {
        }

        public override string getInfo()
        {
            return $"City: {City} Name: {CompanyName} number of rooms: {TotalRooms} rating ({Rating}/5)";
        }
    }

    class BedAndBreakfast : Company
    {
        double Price;
        public BedAndBreakfast(string companyName, string city, double rating, int totalRooms, double price) : base(companyName, city, rating, totalRooms)
        {
            TotalRooms = 2;
            Price = price;
        }
        public override string getInfo()
        {
            return $"City: {City} Name: {CompanyName} number of rooms: {TotalRooms} Price: {Price} rating ({Rating}/5)";
        }
    }
}
