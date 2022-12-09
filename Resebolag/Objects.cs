using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resebolag
{
    class Room
    {
        [JsonProperty("RoomType")]
        private string RoomType { get; set; }
        [JsonProperty("AmountOfRoomType")]
        private int AmountOfRoomType { get; set; }
        [JsonProperty("PricePerNight")]
        private int PricePerNight { get; set; }
        [JsonProperty("HasRoomService")]
        private bool HasRoomService { get; set; }

        public Room(string roomType, int amountOfRoomType, int pricePerNight, bool hasRoomService)
        {
            RoomType = roomType;
            AmountOfRoomType = amountOfRoomType;
            PricePerNight = pricePerNight;
            HasRoomService = hasRoomService;
        }

        public string GetInfo()
        {
            string roomServiceInfo = "";
            if (HasRoomService)
            {
                roomServiceInfo = "Has room service";
            }
            else
            {
                roomServiceInfo = "Dose not include room service";
            }
            return $"Room type: {RoomType}, Amount of {RoomType} rooms: {AmountOfRoomType}, Price per night: {PricePerNight}, {roomServiceInfo}";
        }
    }
}
