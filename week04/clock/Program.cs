using System;
using System.Threading;

namespace clock
{
    public class Clock
    {
        public int Hour { get; set; }
        public int Min { get; set; }
        public int Sec { get; set; }
        public int AlarmHour { get; set; }
        public int AlarmMin { get; set; }
        public int AlarmSec { get; set; }

        public event TickHandler th;
        public event AlarmHandler ah;

        public Clock()
        {
            DateTime nowTime = System.DateTime.Now;
            Hour = nowTime.Hour;
            Min = nowTime.Minute;
            Sec = nowTime.Second;
        }

        public Clock(int h, int m, int s)
        {
            Hour = h;
            Min = m;
            Sec = s;

            if (Hour >= 24 || Hour <= -1) Hour = 0;
            if (Sec >= 60 || Sec <= -1) Sec = 0;
            if (Min >= 60 || Min <= -1) Min = 0;
        }

        public void SetAlarmTime(int h, int m, int s)
        {
            AlarmHour = h;
            AlarmMin = m;
            AlarmSec = s;

            if (AlarmHour >= 24 || AlarmHour <= -1) AlarmHour = 0;
            if (AlarmSec >= 60 || AlarmSec <= -1) AlarmSec = 0;
            if (AlarmMin >= 60 || AlarmMin <= -1) AlarmMin = 0;
        }

        private void AddSec()
        {
            Sec++;
            if (Sec == 60)
            {
                Sec = 0;
                Min++;
            }
            if (Min == 60)
            {
                Min = 0;
                Hour++;
            }
            if (Hour == 24) Hour = 0;
        }

        public void StartClock()
        {
            while (true) 
            {
                Thread.Sleep(1000);
                this.AddSec();
                Tick();
                if (Hour == AlarmHour && Min == AlarmMin && Sec == AlarmSec)
                {
                    Alarm();
                }
            }
        }

        public void Tick()
        {
            th(this);
        }

        public void Alarm()
        {
            ah(this);
        }
    }

    public delegate void TickHandler(Clock c);
    public delegate void AlarmHandler(Clock c);

    class Program
    {
        static void Main(string[] args)
        {
            Clock c = new Clock(10, 10, 10);

            // 注册事件
            c.th += OnTick;
            c.ah += OnAlarm;
            c.SetAlarmTime(10, 10, 20);

            // 启动闹钟
            c.StartClock();
        }

        static void OnTick(Clock c)
        {
            Console.WriteLine("{0}:{1}:{2}", c.Hour, c.Min, c.Sec);
        }

        static void OnAlarm(Clock c)
        {
            Console.WriteLine("The alarm is ringing! Now is {0}:{1}:{2}", c.Hour, c.Min, c.Sec);
        }
    }
}
