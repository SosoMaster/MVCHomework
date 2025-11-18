using Division_Without_Remainder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Division_Without_Remainder.Controller
{
    public class DivisionService
    {
        public DivisionResult Calculate(DivisionInput input)
        {
            int n = input.Numbers.Count;

            double p1 = input.Numbers.Count(x => x % 2 == 0) * 100.0 / n;
            double p2 = input.Numbers.Count(x => x % 3 == 0) * 100.0 / n;
            double p3 = input.Numbers.Count(x => x % 4 == 0) * 100.0 / n;

            return new DivisionResult(p1, p2, p3);
        }
    }
}
