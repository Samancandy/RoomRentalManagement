using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomRentalSystem.Classes
{
    class Payment
    {
        public int PaymentID { get; set; }
        public string CustomerID { get; set; }
        public string RoomNo { get; set; }
        public double Price { get; set; }
        public DateTime PaymentDate { get; set; }
        public Payment(int paymentid, string cusid, string roomno, double price, DateTime pdate)
        {
            this.PaymentID = paymentid;  this.CustomerID = cusid; this.RoomNo = roomno; this.Price = price; this.PaymentDate = pdate;
        }
    }
}
