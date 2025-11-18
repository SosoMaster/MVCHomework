using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pipes_In_A_Pool.Models
{
    public class PoolResult
    {
        public string OutputMessage { get; }

        public PoolResult(string message)
        {
            OutputMessage = message;
        }
    }
}
