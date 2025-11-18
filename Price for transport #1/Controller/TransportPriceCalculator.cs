using Price_for_transport.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_for_transport.Controller
{
    public class TransportPriceCalculator
    {
        private readonly List<TransportOption> options;

        public TransportPriceCalculator()
        {
            options = new List<TransportOption>()
        {
            new Taxi(),
            new Bus(),
            new Train()
        };
        }

        public double GetLowestPrice(int distance, string timeOfDay)
        {
            double minPrice = double.MaxValue;

            foreach (var option in options)
            {
                if (option.CanUse(distance))
                {
                    double price = option.CalculatePrice(distance, timeOfDay);
                    if (price < minPrice)
                    {
                        minPrice = price;
                    }
                }
            }

            return minPrice;
        }
    }
}
