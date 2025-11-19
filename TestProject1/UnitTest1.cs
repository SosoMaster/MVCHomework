using NUnit.Framework;
using Tile_Repair.Controller;
using Tile_Repair.Models;

namespace TestProject1
{
    public class Tests
    {
        private TileRepairService _service;

        [SetUp]
        public void Setup()
        {
            _service = new TileRepairService();
        }

        [Test]
        public void TileRepair_Test_TestingThatCalculateReturnsCorrectValues()
        {

            var input = new TileRepairInput(20, 5, 4, 1, 2);
            var result = _service.Calculate(input);

            Assert.That(result.TilesNeeded, Is.EqualTo(19.9));
            Assert.That(result.TimeNeeded, Is.EqualTo(3.98));
        }
    }
}
