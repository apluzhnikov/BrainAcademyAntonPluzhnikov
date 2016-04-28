using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BA.Lesson16.AP.Lesson2
{
    class ThreadPoolExample
    {
        public void DoWork() {
            for (int i = 0; i < 5; i++)
            {
                ThreadPool.QueueUserWorkItem(Print);
                //Thread.Sleep(2000);
            }
        }

        public void Print(object state) {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Thread id{Thread.CurrentThread.ManagedThreadId} name: {Thread.CurrentThread.Name} reads {i}");
            }

        }
    }
}
