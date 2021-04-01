using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4_2
{
    class Handle
    {
        
        private String alarmTime;

        public String AlarmTime
        {
            get 
            {
                return alarmTime;
            }
            set 
            {
                alarmTime = value;
            } 
        }

        internal void ShowCurrentTime(object sender)
        {
            Console.Write(DateTime.Now.ToString());
            Console.WriteLine("  时钟滴答");
        }

        internal void BellRing(object sender)
        {            
                Console.WriteLine("闹钟响铃！");            
        }
    }
}
