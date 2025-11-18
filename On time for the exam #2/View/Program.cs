using On_time_for_the_exam.Models;
using On_time_for_the_exam.Controller;

namespace On_time_for_the_exam
{
    internal class Program
    {
        public static void Main()
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinute = int.Parse(Console.ReadLine());

            var exam = new ExamTime(examHour, examMinute);
            var arrival = new ArrivalTime(arrivalHour, arrivalMinute);

            var service = new ExamTimeService();
            TimeDifferenceResult result = service.GetArrivalStatus(exam, arrival);

            // Output
            Console.WriteLine(result.Status);
            if (!string.IsNullOrEmpty(result.Description))
            {
                Console.WriteLine(result.Description);
            }
        }
    }
}
