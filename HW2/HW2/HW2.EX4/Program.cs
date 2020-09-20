using System;

namespace HW2.EX4
{

    //1.声明一个委托类型，定义事件处理函数的格式 
    public delegate void TickHandler(object sender,
                                      TickEventArgs args);
    public delegate void AlarmHandler(object sender, AlarmEventArgs args);

    //2.声明事件参数类
    public class TickEventArgs
    {
        public int Hour { get; set; }
        public int Min { get; set; }
        public int Sec { get; set; }
    }
    public class AlarmEventArgs
    {
        public int Hour { get; set; }
        public int Min { get; set; }
        public int Sec { get; set; }
    }

    public class Clock
    {
        //3.定义事件，相当于创建一个委托实例
        public event TickHandler Ticking;
        public event AlarmHandler Alarming;

        //4.
        public void Tick(int hour, int min, int sec)
        {
            Console.WriteLine($"Clock is ticking to {hour}:{min}:{sec}");
            TickEventArgs args = new TickEventArgs()
            {
                Hour = hour,
                Min = min,
                Sec = sec
            };
            //触发Ticking事件
            Ticking(this, args);
        }

        public void Alarm(int hour, int min, int sec)
        {
            Console.WriteLine($"Clock is alarming at {hour}:{min}:{sec}");
            AlarmEventArgs args = new AlarmEventArgs()
            {
                Hour = hour,
                Min = min,
                Sec = sec
            };
            //触发Alarming事件
            Alarming(this, args);
        }
    }

    public class Form
    {
        //5.为clock实例的Ticking事件添加处理方法
        public Clock clock = new Clock();
        public Form()
        {
            clock.Ticking += new TickHandler(Clock_IsTicking);
            clock.Alarming += new AlarmHandler(Clock_IsAlarming);
        }


        //6.
        void Clock_IsTicking(object sender, TickEventArgs args)
        {
            Console.WriteLine($"Clock is ticking!");
        }

        void Clock_IsAlarming(object sender, AlarmEventArgs args)
        {
            Console.WriteLine($"Clock is alarming!");
        }
    }
    class Program
    {   

        static void Main(string[] args)
        {
            Form form1 = new Form();
            form1.clock.Tick(15,30,30);//模拟时钟走到了15点30分30秒
            form1.clock.Alarm(15, 31, 31);//模拟时钟在15点31分31秒报警
        }
    }
}
