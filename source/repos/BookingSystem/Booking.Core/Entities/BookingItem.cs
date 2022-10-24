using Booking.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Booking.Core.Entities
{
    public class BookingItem 
    {
        [Key] public string BookingID { get; set; }
        //public string Name { get; set; }
        public string UserName { get; set; }
        public DateTime BookingTime { get; set; }
        public double TotalPrice { get; set; }
        public int Quantity { get; set; }
        //public string Seats { get; set; }
        public Movie Movie { get; set; }
    }
}
