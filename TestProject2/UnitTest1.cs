using Division_Without_Remainder.Controller;
using Division_Without_Remainder.Models;

namespace TestProject2
{
    public class Tests
    {
        private DivisionInput _service;
        [SetUp]
        public void Setup()
        {
            _service = new DivisionInput(new List<int> {680, 2, 600, 200, 800, 799, 199, 46, 128, 65});
        }

        [Test]
        public void Test1()
        {
            var service = new DivisionService();
            var result = service.Calculate(_service);

            Assert.That(result.P1, Is.EqualTo(70.00));
            Assert.That(result.P2, Is.EqualTo(10.00));
            Assert.That(result.P3, Is.EqualTo(50.00));  
        }
    }
}
