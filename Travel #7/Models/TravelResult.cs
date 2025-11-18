using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel.Models
{
    public class TravelResult
    {
        public string Destination { get; }
        public string VacationType { get; }
        public double Price { get; }

        public TravelResult(string destination, string vacationType, double price)
        {
            Destination = destination;
            VacationType = vacationType;
            Price = price;
        }
    }
}
