using Price_for_transport.Controller;

namespace Price_for_transport
{
    internal class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();

            TransportPriceCalculator calculator = new TransportPriceCalculator();
            double price = calculator.GetLowestPrice(n, timeOfDay);

            Console.WriteLine($"{price:F2}");
        }
    }
}
