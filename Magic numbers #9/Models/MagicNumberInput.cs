using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Numbers.Models
{
    public class MagicNumberInput
    {
        public int MagicNumber { get; }

        public MagicNumberInput(int magicNumber)
        {
            MagicNumber = magicNumber;
        }
    }
}
