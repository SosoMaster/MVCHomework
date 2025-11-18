using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dumb_Password_Generator.Models
{
    public class PasswordGeneratorInput
    {
        public int N { get; }
        public int L { get; }

        public PasswordGeneratorInput(int n, int l)
        {
            N = n;
            L = l;
        }
    }

}
