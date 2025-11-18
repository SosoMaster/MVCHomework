using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Division_Without_Remainder.Models
{
    public class DivisionInput
    {
        public List<int> Numbers { get; }

        public DivisionInput(List<int> numbers)
        {
            Numbers = numbers;
        }
    }
}
