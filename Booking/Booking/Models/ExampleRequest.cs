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
        public List<ExampleRequest> GetCurrentReservations()
        {

            List<ExampleRequest> finalResults = new List<ExampleRequest>();

            ExampleRequest one = new ExampleRequest()
            {
                Name = "John",
                Contact = "6423432341",
                AdultCount = 5,
                ChildCount = 4,
                SpecialInstructions = "Water at table when guests arrive.",
                ReservationTime = DateTime.Now.AddHours(3)
            };
            finalResults.Add(one);

            ExampleRequest two = new ExampleRequest()
            {
                Name = "Dwayne",
                Contact = "635555551",
                AdultCount = 2,
                ChildCount = 1,
                SpecialInstructions = "WWE Hall of Fame dinner.",
                ReservationTime = DateTime.Now.AddHours(3)
            };
            finalResults.Add(two);

            ExampleRequest three = new ExampleRequest()
            {
                Name = "Alan",
                Contact = "6333432341",
                AdultCount = 0,
                ChildCount = 0,
                SpecialInstructions = "Gluten Allergy.",
                ReservationTime = DateTime.Now.AddHours(3)
            };
            finalResults.Add(three);
            return finalResults;
        }
    }
}