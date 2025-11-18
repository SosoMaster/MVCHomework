using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vegetable_market.Models
{
    public class MarketResult
    {
        public double TotalEuro { get; }

        public MarketResult(double totalEuro)
        {
            TotalEuro = totalEuro;
        }
    }
}
