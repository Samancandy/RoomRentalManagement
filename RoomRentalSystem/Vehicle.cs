using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomRentalSystem
{
    public class Vehicle
    {
        public string ID { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public Vehicle()
        {
            ID = "0001"; Model = "Dream"; Color = "black";
        }
        public Vehicle(string id, string model, string color)
        {
            this.ID = id; this.Model = model; this.Color = color;
        }
    }
}
