using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Division_Without_Remainder.Models
{
    public class DivisionInput
    {
        public List<int> _Numbers { get; }

        public DivisionInput(List<int> _numbers)
        {
            _Numbers = _numbers;
        }
    }
}
