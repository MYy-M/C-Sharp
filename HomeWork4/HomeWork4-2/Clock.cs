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
            Console.Write(DateTime.Now.ToString());
            Console.WriteLine("  时钟滴答");
        }

        internal void BellRing(object sender, ElapsedEventArgs e)
        {
            if (DateTime.Now.ToString() == "2021/3/25 23:23:00")
            {
                Console.WriteLine("闹钟响铃！");

            }
        }
    }
}
