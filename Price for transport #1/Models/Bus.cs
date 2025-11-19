using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_for_transport.Models
{
    public class Bus : TransportOption
    {
        private const double _rate = 0.09;

        public override bool CanUse(int distance)
        {
            return distance >= 20;
        }

        public override double CalculatePrice(int distance, string timeOfDay)
        {
            return distance * _rate;
        }
    }
}
