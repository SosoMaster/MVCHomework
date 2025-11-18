using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vegetable_market.Models
{
    public class MarketInput
    {
        public double VegetablePrice { get; }
        public double FruitPrice { get; }
        public int VegetableKg { get; }
        public int FruitKg { get; }

        public MarketInput(double vegetablePrice, double fruitPrice, int vegetableKg, int fruitKg)
        {
            VegetablePrice = vegetablePrice;
            FruitPrice = fruitPrice;
            VegetableKg = vegetableKg;
            FruitKg = fruitKg;
        }
    }
}
