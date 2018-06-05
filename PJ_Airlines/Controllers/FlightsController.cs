using PJ_Airlines.Models;
using PJ_Airlines.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PJ_Airlines.Controllers
{
    public class FlightsController : Controller
    {
        // GET: Flights
        public ActionResult Index()
        {
            var flights = GetFlights();
            return View(flights);
        }

        public IEnumerable<Flight> GetFlights()
        {
            return new List<Flight> ()
            {
                new Flight{Id = 1, Name ="FR 123" },
                new Flight{Id = 2, Name="IE 082" }
            };          
        }

        public ActionResult Details (int id)
        {
            var flight = GetFlights().SingleOrDefault(x => x.Id == id);
            if (flight == null)
            {
                return Content("Flight does not exist");
            }
            return View(flight);
        }

        public ActionResult Random()
        {
            var flight = new Flight()
            {
                Id = 1,
                Name = "EI 161"
            };

            
            var passengers = new List<Passenger>
            {
                new Passenger{Id = 1, Name = "Simon"},
                new Passenger{Id=2, Name="Padraig"}
            };


            var viewModel = new RandomFlightViewModel
            {
                Flight = flight,
                Passengers = passengers
            };

            return View(viewModel);
        }
    }
}