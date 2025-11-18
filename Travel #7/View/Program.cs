using Travel.Controller;
using Travel.Models;

namespace Travel
{
    public class Program
    {
        public static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            var input = new TravelInput(budget, season);
            var service = new TravelService();
            var result = service.PlanTrip(input);

            Console.WriteLine($"Somewhere in {result.Destination}");
            Console.WriteLine($"{result.VacationType} - {result.Price:F2}");
        }
    }
}
