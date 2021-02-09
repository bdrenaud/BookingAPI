﻿using Booking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Booking.Controllers
{
    public class ExampleController : Controller
    {
        // GET: Example
        public ActionResult Index()
        {
            ExampleRequest model = new ExampleRequest();
            model.AdultCount = 3;
            model.ChildCount = 1;
            model.Contact = "645-456-4659";
            model.Name = "Brad";
            model.SpecialInstructions = "Please sit next to fireplace for special event. Thanks";
            model.ReservationTime = DateTime.Now;

            return View(model);
        }
    }
}