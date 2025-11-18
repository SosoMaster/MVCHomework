using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram.Models
{
    public class HistogramInput
    {
        public List<int> Numbers { get; }

        public HistogramInput(List<int> numbers)
        {
            Numbers = numbers;
        }
    }
}
