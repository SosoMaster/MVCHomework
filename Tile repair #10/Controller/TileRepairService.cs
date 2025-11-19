using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tile_Repair.Models;

namespace Tile_Repair.Controller
{
    public class TileRepairService
    {
        private const double _tilePlacementTime = 0.2;

        public TileRepairResult Calculate(TileRepairInput input)
        {
            double areaSquare = input.N * input.N;
            double areaBench = input.M * input.O;
            double areaTile = input.W * input.L;

            double areaToCover = areaSquare - areaBench;
            double tilesNeeded = areaToCover / areaTile;
            double timeNeeded = tilesNeeded * _tilePlacementTime;

            return new TileRepairResult(tilesNeeded, timeNeeded);
        }
    }
}
