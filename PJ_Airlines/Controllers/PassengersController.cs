using PJ_Airlines.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PJ_Airlines.Controllers
{
    public class PassengersController : Controller
    {
        // GET: Passengers
        public ActionResult Index()
        {
            var passengers = GetPassengers();
            return View(passengers);
        }

        private IEnumerable<Passenger> GetPassengers()
        {
            return new List<Passenger>()
            {
                new Passenger{Name="John Smith", Id=1},
                new Passenger{Name="Mary Williams", Id=2}
            };
        }
        public ActionResult Details(int id)
        {
            var passenger = GetPassengers().SingleOrDefault(c => c.Id == id);

            if (passenger == null)
            {
                return HttpNotFound();
            }
            return View(passenger);
        }
    }
}