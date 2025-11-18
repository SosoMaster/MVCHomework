using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tile_Repair.Models
{
    public class TileRepairResult
    {
        public double TilesNeeded { get; }
        public double TimeNeeded { get; }

        public TileRepairResult(double tilesNeeded, double timeNeeded)
        {
            TilesNeeded = tilesNeeded;
            TimeNeeded = timeNeeded;
        }
    }
}
