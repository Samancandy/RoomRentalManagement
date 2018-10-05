using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomRentalSystem.Classes
{
    public class Customer : Person
    {
        private List<Customer> roommate = new List<Customer>();

        public Customer(string id, string name, string gender, DateTime dob, string phone, string address)
            : base(id, name, gender, dob, phone, address)
        {
        }
        private void AddRoommate(Customer rmt)
        {   
            if(this.roommate.Contains(rmt) || this.Equals(rmt) || rmt == null)    // this might be modified later
            {
                return;
            }
            this.roommate.Add(rmt);
            rmt.AddRoommate(this);
        }
        private void RemoveRoommate(Customer rmt)
        {
            if (!this.roommate.Contains(rmt) || this.Equals(rmt) || rmt == null)    // this might be modified later
            {
                return;
            }
            this.roommate.Remove(rmt);
            rmt.RemoveRoommate(this);
        }
        private List<Customer> GetRoommate()
        {
            return this.roommate;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
