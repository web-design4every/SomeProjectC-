using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SE1421_FPTClock
{
    class FPTClock{
        public object q { get; set; }
        int hour { get; set; }
        int minute { get; set; }
        int second { get; set; }
        public string message { get; set; }
        Thread t;
        public FPTClock(int h, int m, int s)
        {
            this.hour = h;
            this.minute = m;
            this.second = s;
        }
        public void Start(string mess)
        {
            this.message = mess;
            t = new Thread(new ThreadStart(Run));
            t.Start();
        }
        public void Run()
        {
            lock (q)
            {
                while (true)
                {
                    DateTime date = DateTime.Now;
                    if (date.Hour == hour && date.Minute == minute && date.Second == second)
                    {
                        Console.WriteLine(message);
                        break;
                    }
                    Thread.Sleep(1000);
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            object a = new object();
            while (true)
            {
                FPTClock c1 = new FPTClock(14, 07, 00) { q = a };
                c1.Start("Play music");
                FPTClock c2 = new FPTClock(14, 07, 07) { q = a};
                c2.Start("Go to work");
                break;
            }
            Console.ReadKey();
        }
    }
}
