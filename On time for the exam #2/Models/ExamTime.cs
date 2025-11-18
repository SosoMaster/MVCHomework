using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace On_time_for_the_exam.Models
{
    public class ExamTime
    {
        public int Hour { get; }
        public int Minute { get; }

        public ExamTime(int hour, int minute)
        {
            Hour = hour;
            Minute = minute;
        }

        public int ToTotalMinutes() => Hour * 60 + Minute;
    }

    public class ArrivalTime
    {
        public int Hour { get; }
        public int Minute { get; }

        public ArrivalTime(int hour, int minute)
        {
            Hour = hour;
            Minute = minute;
        }

        public int ToTotalMinutes() => Hour * 60 + Minute;
    }

    public class TimeDifferenceResult
    {
        public string Status { get; set; }      // "Late", "On time", "Early"
        public string Description { get; set; } // вторият ред – текст с разликата

        public TimeDifferenceResult(string status, string description)
        {
            Status = status;
            Description = description;
        }
    }
}
