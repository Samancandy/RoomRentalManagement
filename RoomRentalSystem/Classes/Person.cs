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
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public Person()
        {
            // TODO: Complete member initialization
        }

        public Person(string id, string name, string gender, DateTime dob, string phone, string address)
        {
            // TODO: Complete member initialization
            this.ID = id;
            this.Name = name;
            this.Gender = gender;
            this.DOB = dob;
            this.Phone = phone;
            this.Address = address;
        }
        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}, {3}, {4}, {5}", ID, Name, Gender, DOB, Phone, Address);
        }
    }
}
