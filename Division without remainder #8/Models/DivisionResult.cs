using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Division_Without_Remainder.Models
{
    public class DivisionResult
    {
        public double P1 { get; } // делят се на 2
        public double P2 { get; } // делят се на 3
        public double P3 { get; } // делят се на 4

        public DivisionResult(double p1, double p2, double p3)
        {
            P1 = p1;
            P2 = p2;
            P3 = p3;
        }
    }
}
