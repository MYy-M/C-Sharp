using System;
using System.Timers;
using System.Threading;

namespace HomeWork4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Clock clock = new Clock();
           
            clock.UseHandle();
            clock.DoTick();
            Console.ReadLine();
        }

    }
}
