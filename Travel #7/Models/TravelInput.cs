using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel.Models
{
    public class TravelInput
    {
        public double Budget { get; }
        public string Season { get; }

        public TravelInput(double budget, string season)
        {
            Budget = budget;
            Season = season;
        }
    }
}
