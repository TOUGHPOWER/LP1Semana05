using System;
using System.Diagnostics;
using System.Threading;

namespace Chronos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaration of instance of classes
            Stopwatch cron1 = new Stopwatch();
            Stopwatch cron2 = new Stopwatch();

            //stopwatch 1 begins counting
            cron1.Start();
            //Program enters pause
            Thread.Sleep(1000);
            //stopwatch 2 begins counting
            cron2.Start();
            //Program enters pause
            Thread.Sleep(1000);
            //Stopwatch 2 Stops
            cron2.Stop();
            //StopWatch 1 Stops
            cron1.Stop();
            
            //Printing of the Stopwatches time
            Console.WriteLine($"StopWatch 1 Runtime in Miliseconds: {cron1.ElapsedMilliseconds}");
            Console.WriteLine($"Stopwatch 2 Runtime in Miliseconds:{cron2.ElapsedMilliseconds}");
        }
    }
}
