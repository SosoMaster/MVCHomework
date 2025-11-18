using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pipes_In_A_Pool.Models
{
    public class PoolInput
    {
        public int Volume { get; }
        public int Pipe1Flow { get; }
        public int Pipe2Flow { get; }
        public double Hours { get; }

        public PoolInput(int volume, int pipe1Flow, int pipe2Flow, double hours)
        {
            Volume = volume;
            Pipe1Flow = pipe1Flow;
            Pipe2Flow = pipe2Flow;
            Hours = hours;
        }
    }
}
