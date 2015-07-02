using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithread_example
{
    public class MyThread
    {
        private int sleep_time;

        public MyThread(int sleep_param)
        {

            this.sleep_time = sleep_param;
        }

        public void Thread1()
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Thread {0} - {1}", this.sleep_time, i);
                System.Threading.Thread.Sleep(this.sleep_time);
            }
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Before start thread");

            MyThread thr1 = new MyThread(0);
            MyThread thr2 = new MyThread(1000);
            MyThread thr3 = new MyThread(2000);

            Thread tid1 = new Thread(new ThreadStart(thr1.Thread1));
            Thread tid2 = new Thread(new ThreadStart(thr2.Thread1));
            Thread tid3 = new Thread(new ThreadStart(thr3.Thread1));

            tid1.Start();
            tid2.Start();
            tid3.Start();
            Console.WriteLine("Done!!!");
            Console.ReadLine();
        }
    }
}
