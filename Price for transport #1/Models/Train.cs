using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_for_transport.Models
{
    public class Train : TransportOption
    {
        private const double Rate = 0.06;

        public override bool CanUse(int distance)
        {
            return distance >= 100;
        }

        public override double CalculatePrice(int distance, string timeOfDay)
        {
            return distance * Rate;
        }
    }
}
