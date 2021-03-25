using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;
namespace HomeWork4_2
{
    class Clock
    {
        internal void ShowCurrentTime(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine(DateTime.Now.ToString());
        }

        internal void BellRing(object sender, ElapsedEventArgs e)
        {
            if (DateTime.Now.ToString() == "2021/3/25 23:23:00")
            {
                Console.WriteLine("响铃");

            }
        }
    }
}
