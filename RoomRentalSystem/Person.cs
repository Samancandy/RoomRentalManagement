using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomRentalSystem
{
    public class Person
    {
        public string ID { get; set; }
        public string CardID { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
        public string Gender { get; set; }
        public string DOB { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public Person(string id, string cardID, string photo, string name, string gender, string dob, string phone, string address)
        {
            this.ID = id; this.Photo = Photo; this.CardID = cardID; this.Name = name; this.Gender = gender; 
            this.DOB = dob; this.Phone = phone; this.Address = address;
        }

        public Person()
        {
            // TODO: Complete member initialization
        }
    }
}
