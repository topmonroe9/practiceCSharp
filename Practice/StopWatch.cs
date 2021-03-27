using System;
using System.Threading;

namespace StopWatch
{
    public class StopWatch
    {
        private DateTime _startTime;
        private DateTime _stopTime;
        private TimeSpan _interval;
        private bool _hasStarted;
        private bool _hasEnded;
        public void Start()
        {
            if (_hasStarted == false)
            {
                _startTime = DateTime.Now;
                _hasStarted = true;
            }
        }

        public void Stop()
        {
            if (_hasStarted == true && _hasEnded == false)
            {
                _stopTime = DateTime.Now;
                _hasEnded = true;
            }
        }

        public void Report()
        {
            
            if (_hasStarted == true && _hasEnded == true)
            {
                _interval = _stopTime - _startTime;
                Console.WriteLine($"Time elapsed: {_interval.Seconds}");
                _hasStarted = false;
                _hasEnded = false;
            }
        }

    }
}