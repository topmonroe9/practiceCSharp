using System;
using System.Threading;

namespace StopWatch
{
    public class StopWatch
    {
        private DateTime startTime;
        private DateTime stopTime;
        private TimeSpan interval;
        private bool hasStarted;
        private bool hasEnded;
        public void Start()
        {
            if (hasStarted == false)
            {
                startTime = DateTime.Now;
                Console.WriteLine(startTime);
                hasStarted = true;
            }
        }

        public void Stop()
        {
            if (hasStarted == true && hasEnded == false)
            {
                stopTime = DateTime.Now;
                hasEnded = true;
            }
        }

        public void Report()
        {
            
            if (hasStarted == true && hasEnded == true)
            {
                interval = stopTime - startTime;
                Console.WriteLine($"Time elapsed: {interval.Seconds}");
                hasStarted = false;
                hasEnded = false;
            }
        }

    }
}