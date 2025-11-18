using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram.Models
{
    public class HistogramResult
    {
        public double P1 { get; set; }   // < 200
        public double P2 { get; set; }   // 200–399
        public double P3 { get; set; }   // 400–599
        public double P4 { get; set; }   // 600–799
        public double P5 { get; set; }   // >= 800
    }
}
