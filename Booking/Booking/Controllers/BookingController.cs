using Booking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Booking.Controllers
{
    public class BookingController : ApiController
    {
        [Route("api/booking/connection")]
        [HttpGet]
        public string Connection()
        {
            return "status ok.";
        }

        [Route("api/booking/exampleReservation")]
        [HttpGet]
        public ExampleRequest ExampleReservation()
        {
            ExampleRequest model = new ExampleRequest();
            model.AdultCount = 3;
            model.ChildCount = 1;
            model.Contact = "645-456-4659";
            model.Name = "Brad";
            model.SpecialInstructions = "Please sit next to fireplace for special event. Thanks";
            model.ReservationTime = DateTime.Now;
            return model;
        }
    }
}
