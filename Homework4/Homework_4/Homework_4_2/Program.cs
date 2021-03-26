using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//使用事件机制，模拟实现一个闹钟功能。
//闹钟可以有嘀嗒（Tick）事件和响铃（Alarm）两个事件。
//在闹钟走时或者响铃时，在控制台显示提示信息.

namespace Homework_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();
            DateTime Time = new DateTime();
            Time = DateTime.Now.AddSeconds(10);
            clock.SetClockTime(Time);
            clock.Start();
        }
    }
}
