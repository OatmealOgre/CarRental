using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRental.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Controllers
{
    public class HomeController : Controller
    {
        private readonly RentalService service;

        public HomeController(RentalService service)
        {
            this.service = service;
        }

        [Route("")]
        public IActionResult Index()
        {
            //service.Create(new Rental()
            //{
            //    BookingDate = DateTime.Now,
            //    CarType = "Small car",
            //    CustomerSSN = "19900520-1111",
            //    RegistrationNumber = "AAA111",
            //    TravelledDistance = 0
            //});
            //service.Create(new Rental()
            //{
            //    BookingDate = DateTime.Now,
            //    CarType = "Van",
            //    CustomerSSN = "19500101-2222",
            //    RegistrationNumber = "BBB222",
            //    TravelledDistance = 10000
            //});


            string a = "";
            var rentals = service.Get();
            foreach (var item in rentals)
            {
                a += item.RegistrationNumber;
                a += " ";
            }
            return Content(a);
        }
    }
}