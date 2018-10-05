using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoomRentalSystem.SubForms
{
    class Rental
    {
        public string ID { get; set; }

        public string CustomerID { get; set; }

        public string RoomNo { get; set; }

        public DateTime RentDate { get; set; }

        public Rental() { }
        public Rental(string id, string cusID, string roomNo, DateTime date)
        {
            this.ID = id; this.CustomerID = cusID; this.RoomNo = roomNo; this.RentDate = date;
        }
        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}, {3}", ID, CustomerID, RoomNo, RentDate);
        }
    }
}
