using Histogram.Models;
using Histogram.Controller;

namespace Histogram
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<int> _numbers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                _numbers.Add(int.Parse(Console.ReadLine()));
            }

            HistogramInput input = new HistogramInput(_numbers);
            HistogramService service = new HistogramService();
            HistogramResult result = service.CalculateHistogram(input);

            Console.WriteLine($"{result.P1:F2}%");
            Console.WriteLine($"{result.P2:F2}%");
            Console.WriteLine($"{result.P3:F2}%");
            Console.WriteLine($"{result.P4:F2}%");
            Console.WriteLine($"{result.P5:F2}%");
        }
    }
}
