using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_for_transport.Models
{
    public class Taxi : TransportOption
    {
        private const double StartFee = 0.70;
        private const double DayRate = 0.79;
        private const double NightRate = 0.90;

        public override bool CanUse(int distance)
        {
            return true; 
        }

        public override double CalculatePrice(int distance, string timeOfDay)
        {
            double rate = timeOfDay == "day" ? DayRate : NightRate;
            return StartFee + distance * rate;
        }
    }
}
