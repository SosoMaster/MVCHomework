using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tile_Repair.Models
{
    public class TileRepairInput
    {
        public double N { get; }
        public double W { get; }
        public double L { get; }
        public double M { get; }
        public double O { get; }

        public TileRepairInput(double n, double w, double l, double m, double o)
        {
            N = n;
            W = w;
            L = l;
            M = m;
            O = o;
        }
    }
}
