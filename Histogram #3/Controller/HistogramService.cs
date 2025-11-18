using Histogram.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram.Controller
{
    public class HistogramService
    {
        public HistogramResult CalculateHistogram(HistogramInput input)
        {
            int n = input.Numbers.Count;

            var result = new HistogramResult();

            result.P1 = input.Numbers.Count(x => x < 200) * 100.0 / n;
            result.P2 = input.Numbers.Count(x => x >= 200 && x <= 399) * 100.0 / n;
            result.P3 = input.Numbers.Count(x => x >= 400 && x <= 599) * 100.0 / n;
            result.P4 = input.Numbers.Count(x => x >= 600 && x <= 799) * 100.0 / n;
            result.P5 = input.Numbers.Count(x => x >= 800) * 100.0 / n;

            return result;
        }
    }
}
