using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SE1421_DemoThread
{
    class Program
    {
        public int[] data = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15,16 };
        public int tong=0;
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.Write("Enter number of thread:");
            int n = int.Parse(Console.ReadLine());
            for(int i=0; i<n; i++)
            {
                ThreadHandler t1 = new ThreadHandler() { Name = "t"+(i+1), begin = i * p.data.Length / n , end = (i+1)*p.data.Length / n };
                t1.Run();
                p.tong += t1.getTong();
            }
            //Main Thread

            Console.WriteLine("Main Thread : " + p.tong);
            Console.ReadKey();
        }
        public class ThreadHandler
        {
            Thread t1;
            public void Start()
            {
                t1 = new Thread(new ThreadStart(Run));
                t1.Start();
                //t1.Join();
            }

            Program p = new Program();
            public string Name { get; set; }
            public int begin { get; set; }
            public int end { get; set; }
            public void Run()
            {
                for (int i = begin; i < end; i++)
                {
                    //Thread.Sleep(100);
                    p.tong += p.data[i];
                    Console.WriteLine(Name + " : " + p.tong);
                }
                Console.WriteLine("Thread "+Name+" : "+p.tong);
            }
            public int getTong()
            {
                return p.tong;
            }
        }
    }
}
