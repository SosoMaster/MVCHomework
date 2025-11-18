using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_for_transport.Models
{
    public abstract class TransportOption
    {
        public abstract bool CanUse(int distance);
        public abstract double CalculatePrice(int distance, string timeOfDay);
    }
}
