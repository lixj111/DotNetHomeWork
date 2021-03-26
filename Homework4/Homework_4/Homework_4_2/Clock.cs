using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4_2
{
    class Clock
    {
        DateTime clocktime = DateTime.Now;

        public delegate void AlarmFun(object sender, DateTime args);
        public delegate void TickFun(object sender, DateTime args);

        public event AlarmFun Alarming;
        public event TickFun Ticking;

        public void Alarm(object sender,DateTime time)
        {
            Console.WriteLine("您设定的时间" + clocktime + "到了！");
        }
        public void Tick(object sender,DateTime time)
        {
            Console.WriteLine("现在的时间是：" + time);
        }
        public Clock()
        {
            Alarming += Alarm;
            Ticking += Tick;
        }

        public void Start()
        {
            while(true)
            {
                DateTime nowtime = DateTime.Now;
                Ticking(this, nowtime);
                if(nowtime.ToString()==clocktime.ToString())
                {
                    Alarming(this, clocktime);
                }
                System.Threading.Thread.Sleep(1000);
            }
        }

        public void SetClockTime(DateTime Time)
        {
            Console.WriteLine("预设时间为："+  Time);
            clocktime = Time;
        }
    }
}
