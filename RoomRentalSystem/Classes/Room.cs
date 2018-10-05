using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomRentalSystem.Classes
{
    public class Room
    {
        public List<Customer> ls_cus = new List<Customer>();
        public string RoomNo { get; set; }
        public string RoomType { get; set; }
        public string RoomSize { get; set; }
        public double Price { get; set; }
        public string Status { get; set; }
        public Room() { }
        public Room(string roomNo, string roomType, string roomSize, double price, string status)
        {
            this.RoomNo = roomNo; this.RoomType = roomType; this.RoomSize = roomSize;
            this.Price = price; this.Status = status;
        }
        public void AddRoommate(Customer cus)
        {
            if (cus == null || ls_cus.Contains(cus)) return;
            ls_cus.Add(cus); 
        }
        public void DelecteRoommate(Customer cus)
        {
            if (cus == null || !ls_cus.Contains(cus)) return;
            ls_cus.Remove(cus);
        }
        public List<Customer> GetRoommate()
        {
            return this.ls_cus;
        }
        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}, {3}, {4}", RoomNo, RoomType, RoomSize, Price, Status);
        }
    }
}
