using System;
using System.Collections.Generic;
using System.Text;

namespace Stopwatch
{
    public class Stopwatch
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }


        public void Start()
        {
            StartTime = DateTime.Now;
        }


        public void Stop()
        {
            EndTime = DateTime.Now;
            TimeSpan duration = StartTime - EndTime;
            Console.WriteLine($"Duration of {duration.TotalSeconds} sek");

        }
    }
}
