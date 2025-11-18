using On_time_for_the_exam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace On_time_for_the_exam.Controller
{
    public class ExamTimeService
    {
        public TimeDifferenceResult GetArrivalStatus(ExamTime exam, ArrivalTime arrival)
        {
            int examMinutes = exam.ToTotalMinutes();
            int arrivalMinutes = arrival.ToTotalMinutes();

            int diff = arrivalMinutes - examMinutes; 

            string status;
            string description = "";

            
            if (diff > 0)
            {
                status = "Late";
            }
            else if (diff >= -30)
            {
                status = "On time";
            }
            else
            {
                status = "Early";
            }

            
            if (diff != 0)
            {
                int absDiff = Math.Abs(diff);
                int hours = absDiff / 60;
                int minutes = absDiff % 60;

                if (hours == 0)
                {
                    description = $"{minutes} minutes " +
                                 (diff < 0 ? "before the start" : "after the start");
                }
                else
                {
                    description = $"{hours}:{minutes:D2} hours " +
                                  (diff < 0 ? "before the start" : "after the start");
                }
            }

            return new TimeDifferenceResult(status, description);
        }
    }
}
