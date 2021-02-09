using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Booking.Models
{
    public class ExampleRequest
    {
        public string Name { get; set; }
        public string Contact { get; set; }
        public int AdultCount { get; set; }
        public int ChildCount { get; set; }
        public string SpecialInstructions { get; set; }
        public DateTime ReservationTime { get; set; }

    }
}