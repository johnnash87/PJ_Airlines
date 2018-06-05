using PJ_Airlines.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PJ_Airlines.ViewModels
{
    public class RandomFlightViewModel
    {
        public Flight Flight { get; set; }
        public List<Passenger> Passengers { get; set; }
    }
}