using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomRentalSystem.Classes
{
    internal class Worker : Person
    {
        public double Salary { get; set; }
        public Worker() { }
        public Worker(string id, string name, string gender, DateTime dob, string phone, string address, double salary)
            : base(id, name, gender, dob, phone, address)
        {
            this.Salary = salary;
        }
    }
}
