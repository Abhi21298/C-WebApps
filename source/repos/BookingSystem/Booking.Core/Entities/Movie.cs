using Booking.Core.Entities.Base;

using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Core.Entities
{
    public class Movie : Entity
    {
        public string MovieName { get; set; }
        public string ImageFile { get; set; }
        public string Description { get; set; }
        public DateTime Datetime { get; set; }
        public int SeatsAvailable { get; set; }
        //public List<Booking> Bookings { get; set; } = new List<Booking>();

    }
}
