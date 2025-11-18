using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Numbers.Models
{
    public class MagicNumberResult
    {
        public List<string> MagicCombinations { get; }

        public MagicNumberResult(List<string> combinations)
        {
            MagicCombinations = combinations;
        }
    }
}
