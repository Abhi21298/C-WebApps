using Booking.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Core.Entities
{
    public class OrderHistory : Entity
    {
        public string BookingID { get; set; }
        public string UserName { get; set; }
        public DateTime BookingTime { get; set; }
        public string MovieName { get; set; }
        public string ImageFile { get; set; }
        public DateTime Datetime { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }
        


    }
}
