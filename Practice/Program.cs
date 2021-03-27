using System;
using System.ComponentModel.Design;
using System.Threading;

namespace StopWatch
{
    class Program
    {
        static void Main()
        {
            var timer = new StopWatch();
            var count = true;
            while (count == true)
            {
                var input = Console.ReadLine();
                switch (input)
                {
                    case "start":
                        timer.Start();
                        break;
                    case "stop":
                        timer.Stop();
                        timer.Report();
                        break;
                    case "exit":
                        count = false;
                        break;
                    default:
                        Console.WriteLine("Invalid entry. Try 'start', 'stop' or 'exit'");
                        break;
                }
            }
        }


    }
}
