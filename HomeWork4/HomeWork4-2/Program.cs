using System;
using System.Timers;
namespace HomeWork4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer();
            timer.Interval = 1000;
            Clock clock = new Clock();
            timer.Elapsed += clock.ShowCurrentTime;
            timer.Elapsed += clock.BellRing;
            timer.Start();
            Console.ReadLine();
        }
    }
}
