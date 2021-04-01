using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;
using System.Threading;
namespace HomeWork4_2
{
    public delegate void ClockHandle(Object Sender);
    class Clock
    {

        public event ClockHandle Tick;
        public event ClockHandle Bellring;

        Handle handle = new Handle();
        public void UseHandle()
        {
            
            Tick += handle.ShowCurrentTime;
            Bellring += handle.BellRing;
        }
        
        public void DoTick()
        {
            while (true) 
            { 
                int interval = 1000;
                Thread.Sleep(interval);

                Tick(this); 

                if (DateTime.Now.ToString() == "2021/3/26 11:03:30" )
                    Bellring(this);
            }
        }
       
       
    }
}
