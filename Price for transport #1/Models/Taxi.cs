using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_for_transport.Models
{
    public class Taxi : TransportOption
    {
        private const double _startFee = 0.70;
        private const double _rayRate = 0.79;
        private const double _nightRate = 0.90;

        public override bool CanUse(int distance)
        {
            return true; 
        }

        public override double CalculatePrice(int distance, string timeOfDay)
        {
            double rate = timeOfDay == "day" ? _rayRate : _nightRate;
            return _startFee + distance * rate;
        }
    }
}
