using System;
using System.Threading;

namespace Clock
{
    public delegate void ClockHander(object sender, ClockTime clockTime);

    public class ClockTime
    {
        private uint hour,min,sec;
        public uint Hour {
            get { return hour; }
            set {
                hour = value;
                if (hour > 24) {
                    hour = 0;
                    Console.WriteLine("输入的时间不符合,系统已自动置零（Hour应该小于24）");
                }; } }
        public uint Min { get {return min; }
            set {
                min = value;
                if (min > 60)
                {
                    min = 0;
                    Console.WriteLine("输入的时间不符合,系统已自动置零（min应该小于60）");
                }; } }
        public uint Sec
        {
            get { return sec; }
            set
            {
                sec = value;
                if (sec > 60)
                {
                    sec = 0;
                    Console.WriteLine("输入的时间不符合,系统已自动置零（sec应该小于60）");
                };
            }
        }
        }

    public class Clock
    {
        public uint set_hour=0, set_min=0, set_sec=0;
        public event ClockHander Tick;
        public event ClockHander Alarm;

        public void ClockRun(uint hour,uint min,uint sec)
        {
            ClockTime clockTime = new ClockTime
            {
                Hour = hour,
                Min = min,
                Sec = sec
            };
            while (true)
            {
                Thread.Sleep(1000);
                clockTime.Sec += 1;
                if(clockTime.Sec == 60)
                {
                    clockTime.Min += 1;
                    clockTime.Sec = 0;
                }
                if(clockTime.Min == 60)
                {
                    clockTime.Hour += 1;
                    clockTime.Min = 0;
                }
                if(clockTime.Hour == 24)
                {
                    clockTime.Hour = 0;
                }

                Tick(this, clockTime);
                Alarm(this, clockTime);
            }
        }

        public void SetTime(uint hour,uint min,uint sec)
        {
            set_hour = hour;
            set_min = min;
            set_sec = sec;
        }
    }

    public class ClockRing
    {
        public Clock ClockRunning = new Clock();

        public ClockRing()
        {
            ClockRunning.Tick += ClockRunning_Tick;
            ClockRunning.Alarm += ClockRunning_Alarm;
        }

        private void ClockRunning_Alarm(object sender, ClockTime clockTime)
        {
           if((clockTime.Hour == ClockRunning.set_hour)&& (clockTime.Min == ClockRunning.set_min) && (clockTime.Sec == ClockRunning.set_sec))
            {
                Console.WriteLine("已经到设定时间~~~");
            }
            else
            {
                return;
            }
        }

        private void ClockRunning_Tick(object sender, ClockTime clockTime)
        {
            Console.WriteLine("嘀嗒......嘀嗒......[当前时间是：{0}：{1}：{2}]",clockTime.Hour,clockTime.Min,clockTime.Sec);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ClockRing clockRing = new ClockRing();
            clockRing.ClockRunning.SetTime(11, 1, 0);
            clockRing.ClockRunning.ClockRun(11, 70, 40);
            Console.ReadLine();
        }
    }
}
