using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vegetable_market.Models;

namespace Vegetable_market.Controller
{
    public class MarketService
    {
        private const double EuroRate = 1.94;

        public MarketResult CalculateRevenue(MarketInput input)
        {
            double totalLv = input.VegetablePrice * input.VegetableKg +
                             input.FruitPrice * input.FruitKg;

            double totalEuro = totalLv / EuroRate;

            return new MarketResult(totalEuro);
        }
    }
}
